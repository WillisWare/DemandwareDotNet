using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid sort order directions.
    /// </summary>
    public enum SortOrderDirection
    {
        [EnumMember(Value = "asc")]
        Ascending,

        [EnumMember(Value = "desc")]
        Descending
    }

    /// <summary>
    /// Represents a sort request.
    /// </summary>
    public sealed class Sort
    {
        #region Properties

        /// <summary>
        /// The name of the field to sort on.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.DisallowNull)]
        public string Field { get; set; }

        /// <summary>
        /// The sort order to be applied when sorting. When omitted, the default sort order (ASC) is used.
        /// </summary>
        [JsonProperty(PropertyName = "sort_order", Required = Required.DisallowNull)]
        public SortOrderDirection SortOrder { get; set; }

        #endregion
    }
}
