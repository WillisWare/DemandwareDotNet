using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid term filter operators.
    /// </summary>
    public enum TermFilterOperator
    {
        /// <summary>
        /// Indicates an IS operator.
        /// </summary>
        [EnumMember(Value = "is")]
        Is,

        /// <summary>
        /// Indicates a ONE OF operator.
        /// </summary>
        [EnumMember(Value = "one_of")]
        OneOf,

        /// <summary>
        /// Indicates an IS NULL operator.
        /// </summary>
        [EnumMember(Value = "is_null")]
        IsNull,

        /// <summary>
        /// Indicates an IS NOT NULL operator.
        /// </summary>
        [EnumMember(Value = "is_not_null")]
        IsNotNull,

        /// <summary>
        /// Indicates a LESS THAN operator.
        /// </summary>
        [EnumMember(Value = "less")]
        Less,

        /// <summary>
        /// Indicates a GREATER THAN operator.
        /// </summary>
        [EnumMember(Value = "greater")]
        Greater,

        /// <summary>
        /// Indicates a NOT IN operator.
        /// </summary>
        [EnumMember(Value = "not_in")]
        NotIn,

        /// <summary>
        /// Indicates a NOT EQUAL operator.
        /// </summary>
        [EnumMember(Value = "neq")]
        NotEqual
    }

    /// <summary>
    /// Represents a term filter.
    /// </summary>
    /// <remarks>
    /// A term filter allows you to restrict a search result to hits that match (exactly) one of the values configured for the filter. A term filter is useful for general restrictions that can be shared between searches. Use term filters whenever the criteria you filter on is a shared property of multiple searches (for example, like filtering by an order status). Use term filters for fields that have a discrete and small set of values only.
    /// <para>
    /// Example: (id="my_id")
    /// <example>
    ///     query: {
    ///         filtered_query: {
    ///             query: { match_all_query: {} },
    ///             filter: {
    ///                 term_filter: {
    ///                     field: "id",
    ///                     operator: "is",
    ///                     values: ["my_id"]
    ///                 }
    ///             }
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (id IN ("my_id","other_id"))
    /// <example>
    ///     query: {
    ///         filtered_query: {
    ///             query: { match_all_query: {} },
    ///             filter: {
    ///                 term_filter: {
    ///                     field: "id",
    ///                     operator: "one_of",
    ///                     values: ["my_id","other_id"]
    ///                 }
    ///             }
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (description=NULL)
    /// <example>
    ///     query: {
    ///         filtered_query: {
    ///             query: { match_all_query: {} },
    ///             filter: {
    ///                 term_filter: {
    ///                     field: "description",
    ///                     operator: "is_null"
    ///                 }
    ///             }
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class TermFilter
    {
        #region Properties

        /// <summary>
        /// The filter field.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.DisallowNull)]
        public string Field { get; set; }

        /// <summary>
        /// The operator to compare the field's values with the given ones.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.DisallowNull)]
        public TermFilterOperator Operator { get; set; }

        /// <summary>
        /// The filter values.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<object> Values { get; set; }

        #endregion
    }
}
