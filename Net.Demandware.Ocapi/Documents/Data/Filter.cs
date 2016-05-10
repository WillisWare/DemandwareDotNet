using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a filter.
    /// </summary>
    /// <remarks>A filter contains a set of objects that define criteria used to select records.</remarks>
    public sealed class Filter
    {
        #region Properties

        /// <summary>
        /// Provides filtering of records using a set of filters combined using a specified operator.
        /// </summary>
        [JsonProperty(PropertyName = "bool_filter", NullValueHandling = NullValueHandling.Ignore)]
        public BoolFilter BooleanFilter { get; set; }

        /// <summary>
        /// Provides filtering based on a query.
        /// </summary>
        [JsonProperty(PropertyName = "query_filter", NullValueHandling = NullValueHandling.Ignore)]
        public QueryFilter QueryFilter { get; set; }

        /// <summary>
        /// Matches records where a field value lies in a specified range.
        /// </summary>
        [JsonProperty(PropertyName = "range_filter", NullValueHandling = NullValueHandling.Ignore)]
        public RangeFilter RangeFilter { get; set; }

        /// <summary>
        /// Matches records where a field (or fields) exactly match some simple value (including null).
        /// </summary>
        [JsonProperty(PropertyName = "term_filter", NullValueHandling = NullValueHandling.Ignore)]
        public TermFilter TermFilter { get; set; }

        #endregion
    }
}
