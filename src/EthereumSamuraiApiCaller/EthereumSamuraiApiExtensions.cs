// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace EthereumSamuraiApiCaller
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EthereumSamuraiAPI.
    /// </summary>
    public static partial class EthereumSamuraiAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='startBlock'>
            /// </param>
            /// <param name='stopBlock'>
            /// </param>
            public static object ApiAddressHistoryByAddressGet(this IEthereumSamuraiAPI operations, string address, int count, int start, long? startBlock = default(long?), long? stopBlock = default(long?))
            {
                return operations.ApiAddressHistoryByAddressGetAsync(address, count, start, startBlock, stopBlock).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='startBlock'>
            /// </param>
            /// <param name='stopBlock'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiAddressHistoryByAddressGetAsync(this IEthereumSamuraiAPI operations, string address, int count, int start, long? startBlock = default(long?), long? stopBlock = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAddressHistoryByAddressGetWithHttpMessagesAsync(address, count, start, startBlock, stopBlock, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            public static object ApiBalanceGetBalanceByAddressGet(this IEthereumSamuraiAPI operations, string address)
            {
                return operations.ApiBalanceGetBalanceByAddressGetAsync(address).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiBalanceGetBalanceByAddressGetAsync(this IEthereumSamuraiAPI operations, string address, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBalanceGetBalanceByAddressGetWithHttpMessagesAsync(address, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockNumber'>
            /// </param>
            public static object ApiBlockNumberByBlockNumberGet(this IEthereumSamuraiAPI operations, long blockNumber)
            {
                return operations.ApiBlockNumberByBlockNumberGetAsync(blockNumber).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockNumber'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiBlockNumberByBlockNumberGetAsync(this IEthereumSamuraiAPI operations, long blockNumber, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBlockNumberByBlockNumberGetWithHttpMessagesAsync(blockNumber, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockHash'>
            /// </param>
            public static object ApiBlockHashByBlockHashGet(this IEthereumSamuraiAPI operations, string blockHash)
            {
                return operations.ApiBlockHashByBlockHashGetAsync(blockHash).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockHash'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiBlockHashByBlockHashGetAsync(this IEthereumSamuraiAPI operations, string blockHash, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBlockHashByBlockHashGetWithHttpMessagesAsync(blockHash, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='count'>
            /// </param>
            public static object ApiErc20BalanceGetErc20BalancePost(this IEthereumSamuraiAPI operations, GetErc20BalanceRequest request = default(GetErc20BalanceRequest), int? start = default(int?), int? count = default(int?))
            {
                return operations.ApiErc20BalanceGetErc20BalancePostAsync(request, start, count).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiErc20BalanceGetErc20BalancePostAsync(this IEthereumSamuraiAPI operations, GetErc20BalanceRequest request = default(GetErc20BalanceRequest), int? start = default(int?), int? count = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiErc20BalanceGetErc20BalancePostWithHttpMessagesAsync(request, start, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='contracts'>
            /// </param>
            public static object ApiErc20BalanceGetErc20BalanceByAddressPost(this IEthereumSamuraiAPI operations, string address, IList<string> contracts = default(IList<string>))
            {
                return operations.ApiErc20BalanceGetErc20BalanceByAddressPostAsync(address, contracts).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='contracts'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiErc20BalanceGetErc20BalanceByAddressPostAsync(this IEthereumSamuraiAPI operations, string address, IList<string> contracts = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiErc20BalanceGetErc20BalanceByAddressPostWithHttpMessagesAsync(address, contracts, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contractAddress'>
            /// </param>
            public static object ApiErc20TokenByContractAddressGet(this IEthereumSamuraiAPI operations, string contractAddress)
            {
                return operations.ApiErc20TokenByContractAddressGetAsync(contractAddress).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contractAddress'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiErc20TokenByContractAddressGetAsync(this IEthereumSamuraiAPI operations, string contractAddress, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiErc20TokenByContractAddressGetWithHttpMessagesAsync(contractAddress, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='query'>
            /// </param>
            public static object ApiErc20TokenGet(this IEthereumSamuraiAPI operations, int count, int start, string query = default(string))
            {
                return operations.ApiErc20TokenGetAsync(count, start, query).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='query'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiErc20TokenGetAsync(this IEthereumSamuraiAPI operations, int count, int start, string query = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiErc20TokenGetWithHttpMessagesAsync(count, start, query, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='count'>
            /// </param>
            public static object ApiErc20TransferHistoryGetErc20TransfersPost(this IEthereumSamuraiAPI operations, GetErc20TransferHistoryRequest request = default(GetErc20TransferHistoryRequest), int? start = default(int?), int? count = default(int?))
            {
                return operations.ApiErc20TransferHistoryGetErc20TransfersPostAsync(request, start, count).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiErc20TransferHistoryGetErc20TransfersPostAsync(this IEthereumSamuraiAPI operations, GetErc20TransferHistoryRequest request = default(GetErc20TransferHistoryRequest), int? start = default(int?), int? count = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiErc20TransferHistoryGetErc20TransfersPostWithHttpMessagesAsync(request, start, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='count'>
            /// </param>
            public static object ApiErc20TransferHistoryGetErc20TransfersV2Post(this IEthereumSamuraiAPI operations, GetErc20TransferHistoryV2Request request = default(GetErc20TransferHistoryV2Request), int? start = default(int?), int? count = default(int?))
            {
                return operations.ApiErc20TransferHistoryGetErc20TransfersV2PostAsync(request, start, count).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiErc20TransferHistoryGetErc20TransfersV2PostAsync(this IEthereumSamuraiAPI operations, GetErc20TransferHistoryV2Request request = default(GetErc20TransferHistoryV2Request), int? start = default(int?), int? count = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiErc20TransferHistoryGetErc20TransfersV2PostWithHttpMessagesAsync(request, start, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionHash'>
            /// </param>
            public static object ApiInternalMessagesTxHashByTransactionHashGet(this IEthereumSamuraiAPI operations, string transactionHash)
            {
                return operations.ApiInternalMessagesTxHashByTransactionHashGetAsync(transactionHash).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionHash'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiInternalMessagesTxHashByTransactionHashGetAsync(this IEthereumSamuraiAPI operations, string transactionHash, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiInternalMessagesTxHashByTransactionHashGetWithHttpMessagesAsync(transactionHash, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='startBlock'>
            /// </param>
            /// <param name='stopBlock'>
            /// </param>
            public static object ApiInternalMessagesByAddressGet(this IEthereumSamuraiAPI operations, string address, int count, int start, long? startBlock = default(long?), long? stopBlock = default(long?))
            {
                return operations.ApiInternalMessagesByAddressGetAsync(address, count, start, startBlock, stopBlock).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='startBlock'>
            /// </param>
            /// <param name='stopBlock'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiInternalMessagesByAddressGetAsync(this IEthereumSamuraiAPI operations, string address, int count, int start, long? startBlock = default(long?), long? stopBlock = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiInternalMessagesByAddressGetWithHttpMessagesAsync(address, count, start, startBlock, stopBlock, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ApiIsAliveGet(this IEthereumSamuraiAPI operations)
            {
                operations.ApiIsAliveGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiIsAliveGetAsync(this IEthereumSamuraiAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiIsAliveGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionHash'>
            /// </param>
            public static object ApiTransactionTxHashByTransactionHashGet(this IEthereumSamuraiAPI operations, string transactionHash)
            {
                return operations.ApiTransactionTxHashByTransactionHashGetAsync(transactionHash).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionHash'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiTransactionTxHashByTransactionHashGetAsync(this IEthereumSamuraiAPI operations, string transactionHash, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiTransactionTxHashByTransactionHashGetWithHttpMessagesAsync(transactionHash, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            public static object ApiTransactionByAddressGet(this IEthereumSamuraiAPI operations, string address, int count, int start)
            {
                return operations.ApiTransactionByAddressGetAsync(address, count, start).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='start'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiTransactionByAddressGetAsync(this IEthereumSamuraiAPI operations, string address, int count, int start, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiTransactionByAddressGetWithHttpMessagesAsync(address, count, start, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockNumber'>
            /// </param>
            public static object ApiTransactionBlockNumberByBlockNumberGet(this IEthereumSamuraiAPI operations, long blockNumber)
            {
                return operations.ApiTransactionBlockNumberByBlockNumberGetAsync(blockNumber).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockNumber'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiTransactionBlockNumberByBlockNumberGetAsync(this IEthereumSamuraiAPI operations, long blockNumber, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiTransactionBlockNumberByBlockNumberGetWithHttpMessagesAsync(blockNumber, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockHash'>
            /// </param>
            public static object ApiTransactionBlockHashByBlockHashGet(this IEthereumSamuraiAPI operations, string blockHash)
            {
                return operations.ApiTransactionBlockHashByBlockHashGetAsync(blockHash).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockHash'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiTransactionBlockHashByBlockHashGetAsync(this IEthereumSamuraiAPI operations, string blockHash, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiTransactionBlockHashByBlockHashGetWithHttpMessagesAsync(blockHash, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
