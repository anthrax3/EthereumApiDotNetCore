// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace EthereumSamuraiApiCaller.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddressHistoryResponse
    {
        /// <summary>
        /// Initializes a new instance of the AddressHistoryResponse class.
        /// </summary>
        public AddressHistoryResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddressHistoryResponse class.
        /// </summary>
        public AddressHistoryResponse(long blockNumber, int blockTimestamp, bool hasError, int messageIndex, int transactionIndex, string fromProperty = default(string), string to = default(string), string transactionHash = default(string), string value = default(string), string gasPrice = default(string), string gasUsed = default(string))
        {
            BlockNumber = blockNumber;
            BlockTimestamp = blockTimestamp;
            FromProperty = fromProperty;
            HasError = hasError;
            MessageIndex = messageIndex;
            To = to;
            TransactionHash = transactionHash;
            TransactionIndex = transactionIndex;
            Value = value;
            GasPrice = gasPrice;
            GasUsed = gasUsed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blockNumber")]
        public long BlockNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blockTimestamp")]
        public int BlockTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public string FromProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hasError")]
        public bool HasError { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageIndex")]
        public int MessageIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactionIndex")]
        public int TransactionIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gasPrice")]
        public string GasPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gasUsed")]
        public string GasUsed { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}