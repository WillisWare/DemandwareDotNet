using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.DataTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid category link types.
    /// </summary>
    public enum CategoryLinkType
    {
        /// <summary>
        /// Indicates an other or unknown link.
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Indicates an accessories link.
        /// </summary>
        [EnumMember(Value = "accessories")]
        Accessories,

        /// <summary>
        /// Indicates a cross-selling link.
        /// </summary>
        [EnumMember(Value = "cross_selling")]
        CrossSelling,

        /// <summary>
        /// Indicates an up-selling link.
        /// </summary>
        [EnumMember(Value = "up_selling")]
        UpSelling,

        /// <summary>
        /// Indicates a spare parts link.
        /// </summary>
        [EnumMember(Value = "spare_parts")]
        SpareParts
    }

    /// <summary>
    /// Document representing a category link.
    /// </summary>
    public sealed class CategoryLink
    {
        #region Properties

        /// <summary>
        /// URL that is used to get this instance.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The date the link was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The position in the source catalog / category for this link relative to the other links in the same category.
        /// </summary>
        [DefaultValue(0.0)]
        [JsonProperty(PropertyName = "position")]
        public double Position { get; set; }

        /// <summary>
        /// The source catalog for the link.
        /// </summary>
        [JsonProperty(PropertyName = "source_catalog_id")]
        public string SourceCatalogId { get; set; }

        /// <summary>
        /// The name of the source catalog.
        /// </summary>
        [JsonProperty(PropertyName = "source_catalog_name")]
        public Localized<string> SourceCatalogName { get; set; }

        /// <summary>
        /// The source category for the link.
        /// </summary>
        [JsonProperty(PropertyName = "source_category_id")]
        public string SourceCategoryId { get; set; }

        /// <summary>
        /// The name of the source category.
        /// </summary>
        [JsonProperty(PropertyName = "source_category_name")]
        public Localized<string> SourceCategoryName { get; set; }

        /// <summary>
        /// The target category for the link.
        /// </summary>
        [JsonProperty(PropertyName = "target_catalog_id")]
        public string TargetCatalogId { get; set; }

        /// <summary>
        /// The name of the target catalog.
        /// </summary>
        [JsonProperty(PropertyName = "target_catalog_name")]
        public Localized<string> TargetCatalogName { get; set; }

        /// <summary>
        /// The target category for the link.
        /// </summary>
        [JsonProperty(PropertyName = "target_category_id")]
        public string TargetCategoryId { get; set; }

        /// <summary>
        /// The name of the target category.
        /// </summary>
        [JsonProperty(PropertyName = "target_category_name")]
        public Localized<string> TargetCategoryName { get; set; }

        /// <summary>
        /// The link type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = "type")]
        public CategoryLinkType Type { get; set; }

        #endregion
    }
}
