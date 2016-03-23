using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Queries
{
    /// <summary>
    /// Enumerates the valid term query operators.
    /// </summary>
    public enum TermQueryOperator
    {
        [EnumMember(Value = "is")]
        Is,

        [EnumMember(Value = "one_of")]
        OneOf,

        [EnumMember(Value = "is_null")]
        IsNull,

        [EnumMember(Value = "is_not_null")]
        IsNotNull,

        [EnumMember(Value = "less")]
        Less,

        [EnumMember(Value = "greater")]
        Greater,

        [EnumMember(Value = "not_in")]
        NotIn,

        [EnumMember(Value = "neq")]
        NotEqual
    }

    /// <summary>
    /// Represents a term query.
    /// </summary>
    /// <remarks>
    /// A term query matches one (or more) value(s) against one (or more) document field(s). A document is considered a hit if one of the values matches (exactly) with at least one of the given fields. The operator "is" can only take one value, while "one_of" can take multiple. If multiple fields are specified, they are combined using the OR operator.
    /// <para>
    /// Elastic only: If used with multiple fields, the query is internally handled as a boolean OR of DisjointMaxQueries (with the dismax matching a value against all fields). The dismax makes sure that a document carrying a single term in multiple fields does not get higher scores than a document matching multiple terms in multiple fields. Example: (id="my_id")
    /// <example>
    ///  query: {
    ///      term_query: {
    ///          fields: ["id"],
    ///          operator: "is",
    ///          values: ["my_id"]
    ///      }
    ///  }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (id IN ("my_id","other_id"))
    /// <example>
    ///  query: {
    ///      term_query: {
    ///          fields: ["id"],
    ///          operator: "one_of",
    ///          values: ["my_id","other_id"]
    ///      }
    ///  }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (id=null)
    /// <example>
    ///  query: {
    ///      term_query: {
    ///         fields: ["description"],
    ///         operator: "is_null"
    ///     }
    ///  }
    /// </example>
    /// </para>
    /// <para>
    /// Example: ((id IN ('generic', 'keyword')) OR (description IN ('generic', 'keyword'))
    /// <example>
    ///  query: {
    ///     term_query: {
    ///         fields: ["id", "description"],
    ///         operator: "one_of",
    ///         values: ["generic","keyword"]
    ///     }
    ///  }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class TermQuery
    {
        #region Properties

        /// <summary>
        /// The document field(s), the value(s) are matched against, combined with the operator.
        /// </summary>
        [JsonProperty(PropertyName = "fields", Required = Required.DisallowNull)]
        [MinLength(1)]
        public IEnumerable<string> Fields { get; set; }

        /// <summary>
        /// Returns the operator to use for the term query.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.DisallowNull)]
        public TermQueryOperator Operator { get; set; }

        /// <summary>
        /// The values, the field(s) are compared against, combined with the operator.
        /// </summary>
        [JsonProperty(PropertyName = "values", Required = Required.DisallowNull)]
        public IEnumerable<object> Values { get; set; }

        #endregion
    }
}
