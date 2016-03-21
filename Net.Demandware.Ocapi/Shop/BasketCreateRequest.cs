using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents a basket creation request.
    /// </summary>
    public sealed class BasketCreateRequest
    {
        #region Properties

        /// <summary>
        /// The currency to be used by the new basket.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        #endregion
    }
}
