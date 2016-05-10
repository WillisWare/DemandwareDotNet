using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a customer address.
    /// </summary>
    public sealed class CustomerAddress : BaseAddress
    {
        #region Properties

        /// <summary>
        /// The id of the address as specified by account owner.
        /// </summary>
        [JsonProperty(PropertyName = "address_id")]
        public string Id { get; set; }

        /// <summary>
        /// The preferred attribute.
        /// </summary>
        [JsonProperty(PropertyName = "preferred")]
        public bool IsPreferred { get; set; }

        #endregion
    }
}
