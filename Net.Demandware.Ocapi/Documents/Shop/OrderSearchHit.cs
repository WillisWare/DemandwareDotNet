using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents an order search hit.
    /// </summary>
    public sealed class OrderSearchHit
    {
        #region Properties

        /// <summary>
        /// The order.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public Order Data { get; set; }

        /// <summary>
        /// The hit's relevance score.
        /// </summary>
        [JsonProperty(PropertyName = "relevance")]
        public double Relevance { get; set; }

        #endregion
    }
}
