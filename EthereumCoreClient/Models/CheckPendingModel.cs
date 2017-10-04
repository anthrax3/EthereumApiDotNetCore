// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.EthereumCoreClient.Models
{
    using Lykke.EthereumCoreClient;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CheckPendingModel
    {
        /// <summary>
        /// Initializes a new instance of the CheckPendingModel class.
        /// </summary>
        public CheckPendingModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckPendingModel class.
        /// </summary>
        public CheckPendingModel(string coinAdapterAddress, string userAddress)
        {
            CoinAdapterAddress = coinAdapterAddress;
            UserAddress = userAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coinAdapterAddress")]
        public string CoinAdapterAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userAddress")]
        public string UserAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CoinAdapterAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CoinAdapterAddress");
            }
            if (UserAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserAddress");
            }
        }
    }
}
