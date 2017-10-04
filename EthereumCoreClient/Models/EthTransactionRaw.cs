// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.EthereumCoreClient.Models
{
    using Lykke.EthereumCoreClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EthTransactionRaw
    {
        /// <summary>
        /// Initializes a new instance of the EthTransactionRaw class.
        /// </summary>
        public EthTransactionRaw()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EthTransactionRaw class.
        /// </summary>
        public EthTransactionRaw(string fromAddress = default(string), string transactionHex = default(string))
        {
            FromAddress = fromAddress;
            TransactionHex = transactionHex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromAddress")]
        public string FromAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactionHex")]
        public string TransactionHex { get; set; }

    }
}
