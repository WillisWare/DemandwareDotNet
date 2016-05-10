using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents the result of product list addresses.
    /// </summary>
    public sealed class AddressLink : SimpleLink
    {
        #region Properties

        /// <summary>
        /// The id of the address.
        /// </summary>
        [JsonProperty(PropertyName = "address_id")]
        [StringLength(256)]
        public string Id { get; set; }

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        #endregion
    }
}
