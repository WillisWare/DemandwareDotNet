using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product type.
    /// </summary>
    public sealed class ProductType
    {
        #region Properties

        /// <summary>
        /// A flag indicating whether the product is a bundle.
        /// </summary>
        [JsonProperty(PropertyName = "bundle")]
        public bool IsBundle { get; set; }

        /// <summary>
        /// A flag indicating whether the product is a standard item.
        /// </summary>
        [JsonProperty(PropertyName = "item")]
        public bool IsItem { get; set; }

        /// <summary>
        /// A flag indicating whether the product is a master.
        /// </summary>
        [JsonProperty(PropertyName = "master")]
        public bool IsMaster { get; set; }

        /// <summary>
        /// A flag indicating whether the product is an option.
        /// </summary>
        [JsonProperty(PropertyName = "option")]
        public bool IsOption { get; set; }

        /// <summary>
        /// A flag indicating whether the product is a set.
        /// </summary>
        [JsonProperty(PropertyName = "set")]
        public bool IsSet { get; set; }

        /// <summary>
        /// A flag indicating whether the product is a variant.
        /// </summary>
        [JsonProperty(PropertyName = "variant")]
        public bool IsVariant { get; set; }

        /// <summary>
        /// A flag indicating whether the product is a variation group.
        /// </summary>
        [JsonProperty(PropertyName = "variation_group")]
        public bool IsVariationGroup { get; set; }

        #endregion
    }
}
