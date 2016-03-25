using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Results
{
    /// <summary>
    /// Represents a result containing an array of content assets.
    /// </summary>
    public sealed class ContentSearchResult : BasePagedResult<Content>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<Content> Data { get; set; }

        /// <summary>
        /// The query String that was searched for.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// The sorted array of search refinements. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "refinements")]
        public IEnumerable<ContentSearchRefinement> Refinements { get; set; }

        /// <summary>
        /// Map of selected refinement attribute id/value(s) pairs. The sorting order is the same like in request URL.
        /// </summary>
        [JsonProperty(PropertyName = "selected_refinements")]
        public IDictionary<string, string> SelectedRefinements { get; set; }

        #endregion
    }
}
