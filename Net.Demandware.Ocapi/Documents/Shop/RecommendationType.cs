using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a recommendation type.
    /// </summary>
    public sealed class RecommendationType
    {
        #region Properties

        /// <summary>
        /// The localized display value of the recommendation type.
        /// </summary>
        [JsonProperty(PropertyName = "display_value")]
        public string DisplayValue { get; set; }

        /// <summary>
        /// The value of the recommendation type.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        #endregion
    }
}
