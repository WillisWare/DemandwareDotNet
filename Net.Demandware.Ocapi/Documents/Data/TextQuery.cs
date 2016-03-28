using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a text query.
    /// </summary>
    /// <remarks>
    /// A text query is used to match some text (i.e. a search phrase possibly consisting of multiple terms) against one or multiple fields. In case multiple fields are provided, the phrase conceptually forms a logical OR over the fields. In this case, the terms of the phrase basically have to match within the text, that would result in concatenating all given fields.
    /// <para>
    /// Example: (coupon_id contains "xmas" )
    /// <example>
    ///     query: {
    ///         text_query: {
    ///             fields: ["coupon_id"],
    ///             search_phrase: "xmas"
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (coupon_id contains "xmas" OR description contains "xmas")
    /// <example>
    ///     query: {
    ///         text_query: {
    ///             fields: ["description", "coupon_id"],
    ///             search_phrase: "xmas"
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// <para>
    /// Example: (description contains "holiday" AND description contains "bojo")
    /// <example>
    ///     query: {
    ///         text_query: {
    ///             fields: ["description"],
    ///             search_phrase: "holiday bogo"
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class TextQuery
    {
        #region Properties

        /// <summary>
        /// The document fields the search phrase has to match against.
        /// </summary>
        [JsonProperty(PropertyName = "fields", Required = Required.DisallowNull)]
        [MinLength(1)]
        public IEnumerable<string> Fields { get; set; }

        /// <summary>
        /// A search phrase, which may consist of multiple terms.
        /// </summary>
        [JsonProperty(PropertyName = "search_phrase", Required = Required.DisallowNull)]
        public string SearchPhrase { get; set; }

        #endregion
    }
}
