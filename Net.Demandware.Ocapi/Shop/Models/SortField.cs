using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a sort field.
    /// </summary>
    public sealed class SortField
    {
        #region Properties

        /// <summary>
        /// The name of the sort field.
        /// </summary>
        [JsonProperty(PropertyName = "field_name", Required = Required.DisallowNull)]
        public string Name { get; set; }

        /// <summary>
        /// The sort order for this sort field - ASC or DESC.
        /// </summary>
        [JsonProperty(PropertyName = "sort_order")]
        public string SortOrder { get; set; }

        #endregion
    }
}
