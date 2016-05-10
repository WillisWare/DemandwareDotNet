using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid operator types.
    /// </summary>
    public enum BoolFilterOperator
    {
        /// <summary>
        /// Indicates an AND operator.
        /// </summary>
        [EnumMember(Value = "and")]
        And,

        /// <summary>
        /// Indicates an OR operator.
        /// </summary>
        [EnumMember(Value = "or")]
        Or,

        /// <summary>
        /// Indicates a NOT operator.
        /// </summary>
        [EnumMember(Value = "not")]
        Not
    }

    /// <summary>
    /// Represents a boolean filter.
    /// </summary>
    /// <remarks>
    /// A boolean filter allows you to combine other filters into (possibly recursive) logical expression trees. A boolean filter is configured with a boolean operator (AND, OR, NOT) and a list of filters the operator relates to. If multiple filters are given to a boolean NOT operator, this is interpreted as a NOT upon a boolean AND of the given filters.
    /// <para>
    /// Example: (id="myId" AND coupon_id="couponOne")
    /// <example>
    ///   query: {
    ///     filtered_query: {
    ///          query: { match_all_query: {} },
    ///          filter: {
    ///              bool_filter: {
    ///                  operator: "and",
    ///                  filters: [
    ///                      { term_filter: { field: "id", operator: "is", values: ["myId"] } },
    ///                      { term_filter: { field: "coupon_id", operator: "is", values: ["couponOne"] } }
    ///                  ]
    ///              }
    ///          }
    ///      }
    ///   }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (id="holidaySale" OR redemption_count BETWEEN(1, 20)
    /// <example>
    ///      query: {
    ///     filtered_query: {
    ///              query: { match_all_query: {} },
    ///              filter: {
    ///                  bool_filter: {
    ///                  operator: "or",
    ///                  filters: [
    ///                      { term_filter: { field: "id", operator: "is", values: ["holidaySale"] } },
    ///                      { range_filter: { field: "redemption_count", from: 1, to: 20 } }
    ///                  ]
    ///              }
    ///          }
    ///      }
    ///   }
    /// </example>
    /// </para>
    /// <para>
    /// Example: NOT(enabled=false AND coupon_id="special")
    /// <example>
    ///      query: {
    ///     filtered_query: {
    ///              query: { match_all_query: {} },
    ///              filter: {
    ///                  bool_filter: {
    ///                  operator: "not",
    ///                  filters: [
    ///                      { term_filter: { field: "enabled", operator: "is", values: [false] } },
    ///                      { term_filter: { field: "coupon_id", operator: "is", values: ["special"] } }
    ///                  ]
    ///              }
    ///          }
    ///      }
    ///   }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class BoolFilter
    {
        #region Properties

        /// <summary>
        /// A list of filters, which are logically combined by an operator.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IEnumerable<Filter> Filters { get; set; }

        /// <summary>
        /// The logical operator the filters are combined with.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.DisallowNull)]
        public BoolFilterOperator Operator { get; set; }

        #endregion
    }
}
