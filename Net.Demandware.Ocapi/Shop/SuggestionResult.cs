using System.Collections.Generic;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents a result containing an array of suggestions.
    /// </summary>
    public sealed class SuggestionResult
    {
        #region Properties

        /// <summary>
        /// The query phrase to search for.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// The suggested phrases.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_phrases")]
        public IEnumerable<string> SuggestedPhrases { get; set; }

        /// <summary>
        /// The sorted list of search hits. This list can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "suggestions")]
        public IEnumerable<Suggestion> Suggestions { get; set; }

        #endregion
    }
}
