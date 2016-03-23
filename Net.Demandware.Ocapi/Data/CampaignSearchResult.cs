using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseModels;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Data.Models;
using Net.Demandware.Ocapi.Data.Queries;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data
{
    /// <summary>
    /// Represents a campaign search result.
    /// </summary>
    public sealed class CampaignSearchResult : BasePagedResult<Campaign>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<Campaign> Data { get; set; }

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
