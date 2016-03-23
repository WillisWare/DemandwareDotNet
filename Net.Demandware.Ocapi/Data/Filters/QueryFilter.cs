using Net.Demandware.Ocapi.Data.Queries;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Filters
{
    /// <summary>
    /// Represents a query filter.
    /// </summary>
    /// <remarks>
    /// A query filter wraps any query and allows it to be used as a filter.
    /// <para>
    /// Example: (coupond_id contains "disabled" AND (enabled=false OR active=false))
    /// <example>
    ///  query : {
    ///     filtered_query: {
    ///         query: { text_query: { fields: ["coupon_id"], search_phrase: "disabled" } },
    ///         filter: {
    ///             query_filter: {
    ///                 query: {
    ///                     term_query: { fields: ["enabled","active"], operator: "is", values: [ false ] }
    ///                 }
    ///             }
    ///         }
    ///     }
    ///  }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class QueryFilter
    {
        #region Properties

        /// <summary>
        /// The query, which should be used as a filter.
        /// </summary>
        [JsonProperty(PropertyName = "query", Required = Required.DisallowNull)]
        public Query Query { get; set; }

        #endregion
    }
}
