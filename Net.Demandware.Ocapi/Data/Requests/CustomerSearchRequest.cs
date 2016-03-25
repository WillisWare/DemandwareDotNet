using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Requests
{
    /// <summary>
    /// Represents a customer search request.
    /// </summary>
    public sealed class CustomerSearchRequest
    {
        #region Properties

        /// <summary>
        /// The count of search hits to include in the result.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [Range(1, 200)]
        public int Count { get; set; }

        /// <summary>
        /// The requested query string.
        /// </summary>
        [JsonProperty(PropertyName = "query", Required = Required.DisallowNull)]
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
        [JsonProperty(PropertyName = "sort")]
        public string Sort { get; set; }

        /// <summary>
        /// The zero-based index of the first search hit to include in the result.
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.DisallowNull)]
        public int StartIndex { get; set; }

        #endregion
    }
}
