using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents registration information for a customer.
    /// </summary>
    public sealed class CustomerRegistration
    {
        #region Properties

        /// <summary>
        /// The customer registration information.
        /// </summary>
        /// <remarks>The mandatory properties for registration are login, last name and email.</remarks>
        [JsonProperty(PropertyName = "customer", Required = Required.DisallowNull)]
        public Customer Customer { get; set; }

        /// <summary>
        /// The password to authorize.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.DisallowNull)]
        [StringLength(4096)]
        public string Password { get; set; }

        #endregion
    }
}
