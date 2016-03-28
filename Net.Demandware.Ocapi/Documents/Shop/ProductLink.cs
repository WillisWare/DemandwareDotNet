using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid types of product links.
    /// </summary>
    public enum ProductLinkType
    {
        [EnumMember(Value = "cross_sell")]
        CrossSell,

        [EnumMember(Value = "replacement")]
        Replacement,

        [EnumMember(Value = "up_sell")]
        UpSell,

        [EnumMember(Value = "accessory")]
        Accessory,

        [EnumMember(Value = "newer_version")]
        NewerVersion,

        [EnumMember(Value = "alt_orderunit")]
        AlternateOrderUnit,

        [EnumMember(Value = "spare_part")]
        SparePart,

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
