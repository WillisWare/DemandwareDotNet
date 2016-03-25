using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseModels;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents an order search result.
    /// </summary>
    public sealed class OrderSearchResult : BasePagedResult<OrderSearchHit>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<OrderSearchHit> Data { get; set; }

        /// <summary>
        /// The requested query string.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// The query arguments.
        /// </summary>
        [JsonProperty(PropertyName = "query_args")]
        public IEnumerable<string> QueryArguments { get; set; }

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        /// <summary>
        /// The sort string.
        /// </summary>
        [JsonProperty(PropertyName = "sort_string")]
        public string SortString { get; set; }

        #endregion
    }
}
