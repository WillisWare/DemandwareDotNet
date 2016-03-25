using System.Collections.Generic;
using Net.Demandware.Ocapi.Data.Models;
using Net.Demandware.Ocapi.Data.Queries;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data
{
    /// <summary>
    /// Represents a search request for retrieving items within the Data API.
    /// </summary>
    /// <remarks>The query is a potentially complex set of expressions. The fields that each query supports are defined within the search resource.</remarks>
    public sealed class SearchRequest : ResultPage
    {
        #region Properties

        /// <summary>
        /// List of expansions to be applied to each search results.
        /// </summary>
        /// <remarks>Expands are optional.</remarks>
        [JsonProperty(PropertyName = "expand")]
        public IEnumerable<string> Expand { get; set; }

        /// <summary>
        /// The query to apply.
        /// </summary>
        [JsonProperty(PropertyName = "query", Required = Required.DisallowNull)]
        public Query Query { get; set; }

        /// <summary>
        /// The field to be selected.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        /// <summary>
        /// The list of sort clauses configured for the search request.
        /// </summary>
        /// <remarks>Sort clauses are optional.</remarks>
        [JsonProperty(PropertyName = "sorts")]
        public IEnumerable<Sort> Sorts { get; set; }

        #endregion
    }
}
