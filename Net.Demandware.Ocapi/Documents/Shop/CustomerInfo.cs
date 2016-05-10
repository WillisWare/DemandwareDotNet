using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents information used to identify a customer.
    /// </summary>
    public sealed class CustomerInfo : BaseClass
    {
        #region Properties

        /// <summary>
        /// The customer's number (id).
        /// </summary>
        [JsonProperty(PropertyName = "customer_id")]
        [StringLength(100)]
        public override string Id { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty(PropertyName = "email", Required = Required.DisallowNull)]
        public string Email { get; set; }

        /// <summary>
        /// The customer's name.
        /// </summary>
        [JsonProperty(PropertyName = "customer_name")]
        public string Name { get; set; }

        /// <summary>
        /// The customer's number (id).
        /// </summary>
        [JsonProperty(PropertyName = "customer_no")]
        [StringLength(100)]
        public string Number { get; set; }

        #endregion
    }
}
