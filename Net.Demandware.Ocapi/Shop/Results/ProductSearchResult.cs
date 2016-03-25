using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Results
{
    /// <summary>
    /// Represents a product search result.
    /// </summary>
    public sealed class ProductSearchResult : BasePagedResult<ProductSearchHit>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<ProductSearchHit> Data { get; set; }

        /// <summary>
        /// The query String that was searched for.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// The sorted array of search refinements. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "refinements")]
        public IEnumerable<ProductSearchRefinement> Refinements { get; set; }

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        /// <summary>
        /// A map of selected refinement attribute id/value(s) pairs.
        /// </summary>
        /// <remarks>The sorting order is the same as in request URL.</remarks>
        [JsonProperty(PropertyName = "selected_refinements")]
        public IDictionary<string, string> SelectedRefinements { get; set; }

        /// <summary>
        /// The id of the applied sorting option.
        /// </summary>
        [JsonProperty(PropertyName = "selected_sorting_option")]
        public string SelectedSortingOption { get; set; }

        /// <summary>
        /// The sorted array of search sorting options. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "sorting_options")]
        public IEnumerable<ProductSearchSortingOption> SortingOptions { get; set; }

        /// <summary>
        /// The suggestion given by the system if no result was found for the submitted search phrase.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_search_phrase")]
        public string SuggestedSearchPhrase { get; set; }

        #endregion
    }
}
