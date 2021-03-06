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

    public partial class CreateExternalTokenModel
    {
        /// <summary>
        /// Initializes a new instance of the CreateExternalTokenModel class.
        /// </summary>
        public CreateExternalTokenModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateExternalTokenModel class.
        /// </summary>
        public CreateExternalTokenModel(bool allowEmission, byte[] divisibility, string tokenName = default(string), string tokenSymbol = default(string), string version = default(string), string initialSupply = default(string))
        {
            TokenName = tokenName;
            AllowEmission = allowEmission;
            TokenSymbol = tokenSymbol;
            Version = version;
            InitialSupply = initialSupply;
            Divisibility = divisibility;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TokenName")]
        public string TokenName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowEmission")]
        public bool AllowEmission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TokenSymbol")]
        public string TokenSymbol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InitialSupply")]
        public string InitialSupply { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Divisibility")]
        public byte[] Divisibility { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Divisibility == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Divisibility");
            }
            if (InitialSupply != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(InitialSupply, "^([1-9][0-9]*)|([0])$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "InitialSupply", "^([1-9][0-9]*)|([0])$");
                }
            }
        }
    }
}
