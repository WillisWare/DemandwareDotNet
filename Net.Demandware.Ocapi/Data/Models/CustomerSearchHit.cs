using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a customer search hit.
    /// </summary>
    public sealed class CustomerSearchHit : BaseCustomer
    {
        #region Properties

        /// <summary>
        /// The customer's credentials.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// The URL addressing the customer.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        #endregion
    }
}
