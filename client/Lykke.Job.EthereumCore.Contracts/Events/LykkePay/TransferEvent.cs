﻿using System;
using Lykke.Job.EthereumCore.Contracts.Enums.LykkePay;

namespace Lykke.Job.EthereumCore.Contracts.Events.LykkePay
{
    public class TransferEvent : Erc20TransferBase
    {
        public DateTime DetectedTime { get; protected set; }
        public string TransactionHash { get; protected set; }
        public string Amount { get; protected set; }
        public string TokenAddress { get; protected set; }
        public string FromAddress { get; protected set; }
        public string ToAddress { get; protected set; }
        public SenderType SenderType { get; protected set; }
        public EventType EventType { get; protected set; }
        public string OperationId { get; protected set; }

        public TransferEvent(string operationId,
            string transactionHash, 
            string amount, 
            string tokenAddress, 
            string fromAddress, 
            string toAddress,
            SenderType senderType,
            EventType eventType) : base(operationId, transactionHash, amount, tokenAddress, fromAddress, toAddress, senderType, eventType)
        {
            OperationId = operationId;
            DetectedTime = DateTime.UtcNow;
            TransactionHash = transactionHash;
            Amount = amount;
            TokenAddress = tokenAddress;
            FromAddress = fromAddress;
            ToAddress = toAddress;
            SenderType = senderType;
            EventType = eventType;
        }
    }
}
