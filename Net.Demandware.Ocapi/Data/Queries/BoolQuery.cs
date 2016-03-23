using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Queries
{
    /// <summary>
    /// Represents a boolean query.
    /// </summary>
    /// <remarks>
    /// A boolean query allows to construct full logical expression trees consisting of other queries (usually term and text queries). A boolean query basically has 3 sets of clauses that 'must', 'should' and / or 'must not' match. If 'must', 'must_not', or 'should' appear in the same boolean query, they are combined logically using the AND operator.
    /// <para>
    /// Example: (id = 'foo' AND description LIKE 'bar')
    /// <example>
    ///     query: {
    ///         bool_query: {
    ///             must: [
    ///                 { term_query: { fields: ["id"], operator: "is", values: ["foo"] } },
    ///                 { text_query: { fields: ["description"], search_phrase: "bar" } }
    ///             ]
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (id = 'foo' OR description LIKE 'bar')
    /// <example>
    ///     query: {
    ///         bool_query: {
    ///             should: [
    ///                 { term_query: { fields: ["id"], operator: "is", values: ["foo"] } },
    ///                 { text_query: { fields: ["description"], search_phrase: "bar" } }
    ///             ]
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (NOT (id = 'foo' AND description LIKE 'bar'))
    /// <example>
    ///     query: {
    ///         bool_query: {
    ///             must_not: [
    ///                 { term_query: { fields: ["id"], operator: "is", values: ["foo"] } },
    ///                 { text_query: { fields: ["description"], search_phrase: "bar" } }
    ///             ]
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: ((coupon_id LIKE "limit" AND description LIKE "limit per customer") AND NOT (enabled=false))
    /// <example>
    ///     query: {
    ///         bool_query: {
    ///             must: [
    ///                 { text_query: { fields: [ "coupon_id" ], search_phrase: "limit" } },
    ///                 { text_query: { fields: [ "description" ], search_phrase: "limit per customer" } }
    ///             ],
    ///             must_not: [
    ///                 { term_query: { fields: [ "enabled" ], operator: "is", values: [false] } }
    ///             ]
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class BoolQuery
    {
        #region Properties

        /// <summary>
        /// List of queries, which must match.
        /// </summary>
        [JsonProperty(PropertyName = "must", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Query> Must { get; set; }

        /// <summary>
        /// List of queries, which must not match.
        /// </summary>
        [JsonProperty(PropertyName = "must_not", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Query> MustNot { get; set; }

        /// <summary>
        /// List of queries, which should match.
        /// </summary>
        [JsonProperty(PropertyName = "should", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Query> Should { get; set; }

        #endregion
    }
}
