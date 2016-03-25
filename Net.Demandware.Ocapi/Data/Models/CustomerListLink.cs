using Net.Demandware.Ocapi.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a link to a customer list.
    /// </summary>
    public sealed class CustomerListLink : SimpleLink
    {
        #region Properties

        /// <summary>
        /// The customerlist id.
        /// </summary>
        [JsonProperty(PropertyName = "customer_list_id")]
        public string CustomerListId { get; set; }

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        #endregion
    }
}
