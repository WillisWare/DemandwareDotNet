using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a suggestion.
    /// </summary>
    public sealed class Suggestion
    {
        #region Properties

        /// <summary>
        /// The sorted list of suggested brands. This list can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "brands")]
        public IEnumerable<string> Brands { get; set; }

        /// <summary>
        /// The sorted list of suggested categories. This list can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IEnumerable<SuggestedCategory> Categories { get; set; }

        /// <summary>
        /// The sorted list of suggested content. This list can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public IEnumerable<SuggestedContent> Content { get; set; }

        /// <summary>
        /// The sorted list of suggested custom suggestions. This list can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "custom_suggestions")]
        public IEnumerable<string> CustomSuggestions { get; set; }

        /// <summary>
        /// The sorted list of suggested products. This list can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "products")]
        public IEnumerable<SuggestedProduct> Products { get; set; }

        #endregion
    }
}
