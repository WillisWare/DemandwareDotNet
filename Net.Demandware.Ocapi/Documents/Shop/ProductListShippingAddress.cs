using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a product list shipping address.
    /// </summary>
    public sealed class ProductListShippingAddress
    {
        #region Properties

        /// <summary>
        /// The id of this address.
        /// </summary>
        [JsonProperty(PropertyName = "address_id", Required = Required.DisallowNull)]
        public string AddressId { get; set; }

        /// <summary>
        /// The city of this address.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string Ciy { get; set; }

        /// <summary>
        /// The first name of this address.
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this address.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        #endregion
    }
}
