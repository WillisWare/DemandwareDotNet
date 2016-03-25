using Net.Demandware.Ocapi.Data.Filters;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Queries
{
    /// <summary>
    /// Represents a filtered query.
    /// </summary>
    /// <remarks>
    /// A filtered query allows to filter the result of a (possibly complex) query using a (possibly complex) filter.
    /// <example>
    ///     query : {
    ///         filtered_query: {
    ///             query: {
    ///                 text_query: { fields: ["coupon_id"], search_phrase: "disabled" }
    ///             },
    ///             filter: {
    ///                 term_filter: {
    ///                     field: "enabled", operator: "is", values: [ false ]
    ///                 }
    ///             }
    ///         }
    ///     }
    /// </example>
    /// </remarks>
    public sealed class FilteredQuery
    {
        #region Properties

        /// <summary>
        /// The (possibly complex) filter object.
        /// </summary>
        [JsonProperty(PropertyName = "filter", Required = Required.DisallowNull)]
        public Filter Filter { get; set; }

        /// <summary>
        /// The query object.
        /// </summary>
        [JsonProperty(PropertyName = "query", Required = Required.DisallowNull)]
        public Query Query { get; set; }

        #endregion
    }
}
