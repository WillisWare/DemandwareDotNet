using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Common;
using Net.Demandware.Ocapi.Data.Models;
using Net.Demandware.Ocapi.Data.Queries;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Results
{
    /// <summary>
    /// Represents a result containing an array of custom objects.
    /// </summary>
    public sealed class CustomObjectSearchResult : BasePagedResult<CustomObject>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. May be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<CustomObject> Data { get; set; }

        /// <summary>
        /// The query passed into the search.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public Query Query { get; set; }

        /// <summary>
        /// The fields that you want to select.
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
