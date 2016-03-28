using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents an order full text search request.
    /// </summary>
    public sealed class OrderSearchRequest
    {
        #region Properties

        /// <summary>
        /// The requested count parameter value.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [Range(1, 200)]
        public int Count { get; set; }

        /// <summary>
        /// The requested query string which limits the results in addition to the search phrase.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// The query arguments.
        /// </summary>
        [JsonProperty(PropertyName = "query_args")]
        public IEnumerable<string> QueryArguments { get; set; }

        /// <summary>
        /// The search fields to be used in case of full text search.
        /// </summary>
        /// <remarks>If the list is null or empty the default search fields will be used.</remarks>
        [JsonProperty(PropertyName = "search_fields")]
        public IEnumerable<string> SearchFields { get; set; }

        /// <summary>
        /// The search phrase.
        /// </summary>
        [JsonProperty(PropertyName = "search_phrase")]
        public string SearchPhrase { get; set; }

        /// <summary>
        /// The select parameter used to configure the search result document.
        /// </summary>
        /// <remarks>See "API Usage > Property selection" for more information how to define a property selector.</remarks>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        /// <summary>
        /// The sort fields list.
        /// </summary>
        [JsonProperty(PropertyName = "sort_fields")]
        public IEnumerable<SortField> SortFields { get; set; }

        /// <summary>
        /// The requested start parameter value.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int StartIndex { get; set; }

        #endregion
    }
}
