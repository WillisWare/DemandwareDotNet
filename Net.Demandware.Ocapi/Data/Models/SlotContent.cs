using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Enumerates the valid slot content types.
    /// </summary>
    public enum SlotContentType
    {
        [EnumMember(Value = "products")]
        Products,

        [EnumMember(Value = "categories")]
        Categories,

        [EnumMember(Value = "content_assets")]
        ContentAssets,

        [EnumMember(Value = "html")]
        Html,

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
