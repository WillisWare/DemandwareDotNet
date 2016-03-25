using System.ComponentModel;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Filters
{
    /// <summary>
    /// Represents a range filter.
    /// </summary>
    /// <remarks>
    /// A range filter allows you to restrict a search result to hits that have values for a given attribute that fall into a given value range. The range filter supports several value types and relies on the natural sorting of the value type for range interpretation. Value ranges can be open ended (at one end only). It is configurable whether the lower and/or the upper bound is inclusive or exclusive.
    /// A range filter is useful for general restrictions that can be shared between searches(like a static date range) as the filter result is cached in memory.Range filters are not appropriate if the range is expected to be different for every single query(like if the user controls the date range down to the hour via some UI control). Range filters are inclusive by default.
    /// <para>
    /// Example: ( redemption_count BETWEEN (0,10] )
    /// <example>
    ///     query: {
    ///         filtered_query: {
    ///             query: { match_all_query: {} },
    ///             filter: {
    ///                 range_filter: {
    ///                     field: "redemption_count",
    ///                     from: 0,
    ///                     to: 10,
    ///                     from_inclusive: false
    ///                 }
    ///             }
    ///         }
    ///     }
    /// </example>
    /// </para>
    /// </remarks>
    public sealed class RangeFilter
    {
        #region Properties

        /// <summary>
        /// The search field.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.DisallowNull)]
        public string Field { get; set; }

        /// <summary>
        /// The configured lower bound of the filter range.
        /// </summary>
        /// <remarks>The lower bound is optional. If not given, the range is open ended with respect to the lower bound.</remarks>
        [JsonProperty(PropertyName = "from")]
        public object From { get; set; }

        /// <summary>
        /// A flag indicating whether the lower bound of the range is inclusive (or exclusive).
        /// </summary>
        /// <remarks>The default is true (which means that the given lower bound is inclusive).</remarks>
        [JsonProperty(PropertyName = "from_inclusive")]
        [DefaultValue(true)]
        public bool IsFromInclusive { get; set; }

        /// <summary>
        /// A flag indicating whether the upper bound of the range is inclusive (or exclusive).
        /// </summary>
        /// <remarks>The default is true (which means that the given upper bound is inclusive).</remarks>
        [JsonProperty(PropertyName = "to_inclusive")]
        [DefaultValue(true)]
        public bool IsToInclusive { get; set; }

        /// <summary>
        /// The configured upper bound of the filter range.
        /// </summary>
        /// <remarks>The upper bound is optional. If not given, the range is open ended with respect to the upper bound.</remarks>
        [JsonProperty(PropertyName = "to")]
        public object To { get; set; }

        #endregion
    }
}
