﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Repositories;
using Core.Settings;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using Services.Coins;
using AzureStorage.Queue;
using Common.Log;
using System.Numerics;
using Core.Utils;

namespace Services
{
    public class DepositContractTransaction : QueueMessageBase
    {
        public string DepositContractAddress { get; set; }

        public string UserAddress { get; set; }
        public string CoinAdapterAddress { get; set; }

        //System.Numerics.BigInteger
        public string Amount { get; set; }
        public DateTime CreateDt { get; set; }

    }

    public interface IDepositContractTransactionService
    {
        Task PutContractTransferTransaction(DepositContractTransaction tr);
        Task TransferToCoinAdapterContract(DepositContractTransaction contractTransferTr);
    }

    public class DepositContractTransactionService : IDepositContractTransactionService
    {
        private readonly ILog _logger;
        private readonly IBaseSettings _baseSettings;
        private readonly IQueueExt _queue;
        private readonly IDepositContractRepository _depositContractRepository;
        private readonly IDepositContractService _depositContractService;
        private readonly IUserTransferWalletRepository _userTransferWalletRepository;
        private readonly IUserPaymentHistoryRepository _userPaymentHistoryRepository;
        private readonly ICoinTransactionService _cointTransactionService;
        private readonly ICoinTransactionRepository _coinTransactionRepository;
        private readonly ICoinEventService _coinEventService;
        private readonly IEventTraceRepository _eventTraceRepository;

        public DepositContractTransactionService(Func<string, IQueueExt> queueFactory,
            ILog logger,
            IExchangeContractService coinContractService,
            IBaseSettings baseSettings,
            IDepositContractRepository depositContractRepository,
            IDepositContractService depositContractService,
            IUserTransferWalletRepository userTransferWalletRepository,
            IUserPaymentHistoryRepository userPaymentHistoryRepository,
            ICoinTransactionService cointTransactionService,
            ICoinTransactionRepository coinTransactionRepository,
            ICoinEventService coinEventService,
            IEventTraceRepository eventTraceRepository)
        {
            _eventTraceRepository = eventTraceRepository;
            _logger = logger;
            _baseSettings = baseSettings;
            _queue = queueFactory(Constants.ContractTransferQueue);
            _depositContractRepository = depositContractRepository;
            _depositContractService = depositContractService;
            _userTransferWalletRepository = userTransferWalletRepository;
            _userPaymentHistoryRepository = userPaymentHistoryRepository;
            _cointTransactionService = cointTransactionService;
            _coinTransactionRepository = coinTransactionRepository;
            _coinEventService = coinEventService;
        }

        public async Task PutContractTransferTransaction(DepositContractTransaction tr)
        {
            await _queue.PutRawMessageAsync(JsonConvert.SerializeObject(tr));
        }

        public async Task TransferToCoinAdapterContract(DepositContractTransaction contractTransferTr)
        {
            try
            {
                //string coinAdapterAddress = contractTransferTr.CoinAdapterAddress;
                //IDepositContract depositContract = await _depositContractRepository.GetByAddressAsync(contractTransferTr.DepositContractAddress);
                //var balance = await _depositContractService.GetBalance(contractTransferTr.DepositContractAddress, coinAdapterAddress);

                //if (balance == 0)
                //{
                //    await UpdateUserTransferWallet(contractTransferTr);
                //    await _logger.WriteInfoAsync("TransferContractTransactionService", "TransferToCoinContract", "", 
                //        $"Can't cashin: there is no funds on the transfer contract {contractTransferTr.DepositContractAddress}", DateTime.UtcNow);

                //    return;
                //}

                //var opId = $"InternalOperation-{Guid.NewGuid().ToString()}";
                //var transactionHash = await _depositContractService.RecievePaymentFromTransferContract(depositContract.ContractAddress,
                //    depositContract.CoinAdapterAddress);
                //await _coinEventService.PublishEvent(new CoinEvent(opId, 
                //    transactionHash, contractTransferTr.DepositContractAddress, contractTransferTr.UserAddress,
                //    balance.ToString(), CoinEventType.CashinStarted, depositContract.CoinAdapterAddress));
                //await _eventTraceRepository.InsertAsync(new EventTrace()
                //{
                //    Note = $"First Cashin appearance {transactionHash} put in {Constants.TransactionMonitoringQueue}",
                //    OperationId = opId,
                //    TraceDate = DateTime.UtcNow
                //});
                //await _userPaymentHistoryRepository.SaveAsync(new UserPaymentHistory()
                //{
                //    Amount = balance.ToString(),
                //    ToAddress = contractEntity.ContractAddress,
                //    AdapterAddress = contractEntity.CoinAdapterAddress,
                //    CreatedDate = DateTime.UtcNow,
                //    Note = $"Cashin from transfer contract {contractEntity.ContractAddress}",
                //    TransactionHash = transactionHash,
                //    UserAddress = contractTransferTr.UserAddress
                //});

                ////await UpdateUserTransferWallet(contractTransferTr);
                //await _logger.WriteInfoAsync("ContractTransferTransactionService", "TransferToCoinContract", "",
                //    $"Transfered {balance} from transfer contract to \"{contractTransferTr.CoinAdapterAddress}\" by transaction \"{transactionHash}\". Receiver = {contractEntity.UserAddress}");
            }
            catch (Exception e)
            {
                await _logger.WriteErrorAsync("TransferContractTransactionService", "TransferToCoinContract",
                            $"{contractTransferTr.DepositContractAddress} - {contractTransferTr.CoinAdapterAddress} - {contractTransferTr.Amount}", e);
                throw;
            }
        }

        private async Task UpdateUserTransferWallet(DepositContractTransaction contractTransferTr)
        {
            await _userTransferWalletRepository.ReplaceAsync(new UserTransferWallet()
            {
                LastBalance = "",
                TransferContractAddress = contractTransferTr.DepositContractAddress,
                UpdateDate = DateTime.UtcNow,
                UserAddress = contractTransferTr.UserAddress
            });
        }
    }
}
