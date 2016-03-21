using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a variation attribute value.
    /// </summary>
    public sealed class VariationAttributeValue
    {
        #region Properties

        /// <summary>
        /// The localized description of the variation value.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The first product image for the configured viewtype and this variation value.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        /// <summary>
        /// The first product image for the configured viewtype and this variation value. (typically the swatch image)
        /// </summary>
        [JsonProperty(PropertyName = "image_swatch")]
        public Image ImageSwatch { get; set; }

        /// <summary>
        /// A flag indicating whether at least one variant with this variation attribute value is available to sell.
        /// </summary>
        [JsonProperty(PropertyName = "orderable")]
        public bool isOrderable { get; set; }

        /// <summary>
        /// The localized display name of the variation value.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The actual variation value.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.Always)]
        [MinLength(1)]
        public string Value { get; set; }

        #endregion
    }
}
