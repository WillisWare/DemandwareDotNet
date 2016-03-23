using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Queries
{
    /// <summary>
    /// Represents a query.
    /// </summary>
    /// <remarks>A query contains a set of objects that define criteria used to select records.</remarks>
    public sealed class Query
    {
        #region Properties

        /// <summary>
        /// Formulates a complex boolean expression using query objects as criteria.
        /// </summary>
        [JsonProperty(PropertyName = "boolean_query", NullValueHandling = NullValueHandling.Ignore)]
        public BoolQuery BooleanQuery { get; set; }

        /// <summary>
        /// Allows for filtering of records based on both a query and a filter.
        /// </summary>
        [JsonProperty(PropertyName = "filtered_query", NullValueHandling = NullValueHandling.Ignore)]
        public FilteredQuery FilteredQuery { get; set; }

        /// <summary>
        /// Returns all records.
        /// </summary>
        [JsonProperty(PropertyName = "match_all_query", NullValueHandling = NullValueHandling.Ignore)]
        public MatchAllQuery MatchAllQuery { get; set; }

        /// <summary>
        /// Matches records where a field (or fields) exactly match some simple value (including null).
        /// </summary>
        [JsonProperty(PropertyName = "term_query", NullValueHandling = NullValueHandling.Ignore)]
        public TermQuery TermQuery { get; set; }

        /// <summary>
        /// Matches records where a field (or fields) contain a search phrase.
        /// </summary>
        [JsonProperty(PropertyName = "text_query", NullValueHandling = NullValueHandling.Ignore)]
        public TextQuery TextQuery { get; set; }

        #endregion
    }
}
