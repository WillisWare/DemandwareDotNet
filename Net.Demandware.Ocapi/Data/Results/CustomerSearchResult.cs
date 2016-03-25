using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Data.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Results
{
    /// <summary>
    /// Represents a result containing an array of customer search hits.
    /// </summary>
    public sealed class CustomerSearchResult : BasePagedResult<CustomerSearchHit>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<CustomerSearchHit> Data { get; set; }

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
        public string Sort { get; set; }

        #endregion
    }
}
