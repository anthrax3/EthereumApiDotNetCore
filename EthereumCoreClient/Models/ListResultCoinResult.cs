// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.EthereumCoreClient.Models
{
    using Lykke.EthereumCoreClient;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ListResultCoinResult
    {
        /// <summary>
        /// Initializes a new instance of the ListResultCoinResult class.
        /// </summary>
        public ListResultCoinResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListResultCoinResult class.
        /// </summary>
        public ListResultCoinResult(IList<CoinResult> data = default(IList<CoinResult>))
        {
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<CoinResult> Data { get; set; }

    }
}
