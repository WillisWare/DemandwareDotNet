using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a product search sorting option.
    /// </summary>
    public sealed class ProductSearchSortingOption
    {
        #region Properties

        /// <summary>
        /// The id of the sorting option.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The localized label of the sorting option.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        #endregion
    }
}
