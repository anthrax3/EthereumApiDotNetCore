// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.EthereumCore.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PrivateWalletEstimateTransaction
    {
        /// <summary>
        /// Initializes a new instance of the PrivateWalletEstimateTransaction
        /// class.
        /// </summary>
        public PrivateWalletEstimateTransaction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateWalletEstimateTransaction
        /// class.
        /// </summary>
        public PrivateWalletEstimateTransaction(string fromAddress = default(string), string toAddress = default(string), string ethAmount = default(string), string gasPrice = default(string))
        {
            FromAddress = fromAddress;
            ToAddress = toAddress;
            EthAmount = ethAmount;
            GasPrice = gasPrice;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FromAddress")]
        public string FromAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ToAddress")]
        public string ToAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EthAmount")]
        public string EthAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GasPrice")]
        public string GasPrice { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EthAmount != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(EthAmount, "^[1-9][0-9]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "EthAmount", "^[1-9][0-9]*$");
                }
            }
            if (GasPrice != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(GasPrice, "^[1-9][0-9]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "GasPrice", "^[1-9][0-9]*$");
                }
            }
        }
    }
}
