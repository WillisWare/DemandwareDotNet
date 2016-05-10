using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid slot content types.
    /// </summary>
    public enum SlotContentType
    {
        /// <summary>
        /// Indicates a products slot.
        /// </summary>
        [EnumMember(Value = "products")]
        Products,

        /// <summary>
        /// Indicates a categories slot.
        /// </summary>
        [EnumMember(Value = "categories")]
        Categories,

        /// <summary>
        /// Indicates a content assets slot.
        /// </summary>
        [EnumMember(Value = "content_assets")]
        ContentAssets,

        /// <summary>
        /// Indicates an HTML slot.
        /// </summary>
        [EnumMember(Value = "html")]
        Html,

        /// <summary>
        /// Indicates a recommended products slot.
        /// </summary>
        [EnumMember(Value = "recommended_products")]
        RecommendedProducts
    }

    /// <summary>
    /// Represents the content type for a slot.
    /// </summary>
    public sealed class SlotContent
    {
        #region Properties

        /// <summary>
        /// The HTML body (valid only for type 'html').
        /// </summary>
        [JsonProperty(PropertyName = "body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// The category ids (valid only for type 'categories').
        /// </summary>
        [JsonProperty(PropertyName = "category_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> CategoryIds { get; set; }

        /// <summary>
        /// The content asset ids (valid only for type 'content_assets').
        /// </summary>
        [JsonProperty(PropertyName = "content_asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ContentAssetIds { get; set; }

        /// <summary>
        /// The product ids (valid only for type 'products').
        /// </summary>
        [JsonProperty(PropertyName = "product_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductIds { get; set; }

        /// <summary>
        /// The type of content in the slot.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.DisallowNull)]
        public SlotContentType Type { get; set; }

        #endregion
    }
}
