using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product list registrant.
    /// </summary>
    public sealed class ProductListRegistrant
    {
        #region Properties

        /// <summary>
        /// The email of the registrant.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the registrant.
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the registrant.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The role of the registrant.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        #endregion
    }
}
