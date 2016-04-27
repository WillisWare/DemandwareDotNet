using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid types of product links.
    /// </summary>
    public enum ProductLinkType
    {
        /// <summary>
        /// Indicates a cross-sell type.
        /// </summary>
        [EnumMember(Value = "cross_sell")]
        CrossSell,

        /// <summary>
        /// Indicates a replacement type.
        /// </summary>
        [EnumMember(Value = "replacement")]
        Replacement,

        /// <summary>
        /// Indicates an upsell type.
        /// </summary>
        [EnumMember(Value = "up_sell")]
        UpSell,

        /// <summary>
        /// Indicates an accessory type.
        /// </summary>
        [EnumMember(Value = "accessory")]
        Accessory,

        /// <summary>
        /// Indicates a newer version type.
        /// </summary>
        [EnumMember(Value = "newer_version")]
        NewerVersion,

        /// <summary>
        /// Indicates an alternate unit type.
        /// </summary>
        [EnumMember(Value = "alt_orderunit")]
        AlternateOrderUnit,

        /// <summary>
        /// Indicates a spare part type.
        /// </summary>
        [EnumMember(Value = "spare_part")]
        SparePart,

        /// <summary>
        /// Indicates an "other" type.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }

    /// <summary>
    /// Represents a link between two products. It contains the id of the source and target products, the type of product link, and URLs to retrieve product data.
    /// </summary>
    public sealed class ProductLink
    {
        #region Properties

        /// <summary>
        /// The semantic id of the product from which this product link is coming.
        /// </summary>
        [JsonProperty(PropertyName = "source_product_id")]
        public string SourceProductId { get; set; }

        /// <summary>
        /// The URL addressing the product from which this product link is coming.
        /// </summary>
        [JsonProperty(PropertyName = "source_product_link")]
        public string SourceProductLink { get; set; }

        /// <summary>
        /// The semantic id of the product to which this product link is pointing.
        /// </summary>
        [JsonProperty(PropertyName = "target_product_id")]
        public string TargetProductId { get; set; }

        /// <summary>
        /// The URL addressing the product to which this product link is pointing.
        /// </summary>
        [JsonProperty(PropertyName = "target_product_link")]
        public string TargetProductLink { get; set; }

        /// <summary>
        /// The type of this product link.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ProductLinkType Type { get; set; }

        #endregion
    }
}
