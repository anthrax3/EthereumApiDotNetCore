﻿using System;
using System.Threading.Tasks;
using Services.Coins;
using Common.Log;
using Common;
using Lykke.JobTriggers.Triggers.Attributes;
using Core;
using Services.Coins.Models;
using Lykke.JobTriggers.Triggers.Bindings;
using Core.Settings;
using Core.Notifiers;
using Core.Repositories;
using Services;
using Services.New.Models;
using System.Numerics;

namespace EthereumJobs.Job
{
    public class MonitoringOperationJob
    {
        private readonly ILog _log;
        private readonly IBaseSettings _settings;
        private readonly IPendingOperationService _pendingOperationService;
        private readonly IExchangeContractService _exchangeContractService;
        private readonly ICoinEventService _coinEventService;
        private readonly ITransferContractService _transferContractService;

        public MonitoringOperationJob(ILog log, IBaseSettings settings,
            IPendingOperationService pendingOperationService, IExchangeContractService exchangeContractService, ICoinEventService coinEventService, ITransferContractService transferContractService)
        {
            _exchangeContractService = exchangeContractService;
            _pendingOperationService = pendingOperationService;
            _settings = settings;
            _log = log;
            _coinEventService = coinEventService;
            _transferContractService = transferContractService;
        }

        [QueueTrigger(Constants.PendingOperationsQueue, 100, true)]
        public async Task Execute(OperationHashMatchMessage opMessage, QueueTriggeringContext context)
        {
            try
            {
                var operation = await _pendingOperationService.GetOperationAsync(opMessage.OperationId);
                var guid = Guid.Parse(operation.OperationId);
                var amount = BigInteger.Parse(operation.Amount);
                BigInteger resultAmount;
                string transactionHash = null;
                CoinEventType? eventType = null;
                BigInteger currentBalance = await _transferContractService.GetBalanceOnAdapter(operation.CoinAdapterAddress, operation.FromAddress);

                switch (operation.OperationType)
                {
                    case OperationTypes.Cashout:
                        eventType = CoinEventType.CashoutStarted;
                        resultAmount = amount;
                        if (!CheckBalance(currentBalance, resultAmount)) break;
                        transactionHash = await _exchangeContractService.CashOut(guid,
                            operation.CoinAdapterAddress,
                            operation.FromAddress,
                            operation.ToAddress, amount, operation.SignFrom);
                        break;
                    case OperationTypes.Transfer:
                        eventType = CoinEventType.TransferStarted;
                        resultAmount = amount;
                        if (!CheckBalance(currentBalance, resultAmount)) break;
                        transactionHash = await _exchangeContractService.Transfer(guid, operation.CoinAdapterAddress,
                            operation.FromAddress,
                            operation.ToAddress, amount, operation.SignFrom);
                        break;
                    case OperationTypes.TransferWithChange:
                        eventType = CoinEventType.TransferStarted;
                        BigInteger change = BigInteger.Parse(operation.Change);
                        resultAmount = amount - change;
                        if (!CheckBalance(currentBalance, resultAmount)) break;
                        transactionHash = await _exchangeContractService.TransferWithChange(guid, operation.CoinAdapterAddress,
                            operation.FromAddress,
                            operation.ToAddress, amount, operation.SignFrom, change, operation.SignTo);
                        break;
                    default:
                        await _log.WriteWarningAsync("MonitoringOperationJob", "Execute", $"Can't find right operation type for {opMessage.OperationId}", "");
                        break;
                }

                if (transactionHash != null && eventType != null)
                {
                    await _pendingOperationService.MatchHashToOpId(transactionHash, operation.OperationId);
                    await _coinEventService.PublishEvent(new CoinEvent(operation.OperationId.ToString(), transactionHash, operation.FromAddress, operation.ToAddress, resultAmount.ToString(), eventType.Value, operation.CoinAdapterAddress));

                    return;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != opMessage.LastError)
                    await _log.WriteWarningAsync("MonitoringOperationJob", "Execute", $"OperationId: [{opMessage.OperationId}]", "");

                opMessage.LastError = ex.Message;

                opMessage.DequeueCount++;


                await _log.WriteErrorAsync("MonitoringOperationJob", "Execute", "", ex);
                return;
            }

            context.MoveMessageToEnd();
            context.SetCountQueueBasedDelay(_settings.MaxQueueDelay, 200);
        }

        private bool CheckBalance(BigInteger currentBalance, BigInteger amount)
        {
            return currentBalance >= amount;
        }
    }
}