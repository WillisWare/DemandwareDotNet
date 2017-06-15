using Net.Demandware.Ocapi.DataTypes;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a product variation.
    /// </summary>
    public sealed class Variant : BaseVariationGroup
    {
        #region Properties

        /// <summary>
        /// Inventory "Available to Sell" of the product.
        /// </summary>
        [JsonProperty(PropertyName = "ats")]
        public decimal AvailableToSell { get; set; }

        /// <summary>
        /// Currency code for the price of the product.
        /// </summary>
        [JsonProperty(PropertyName = "price_currency")]
        public string Currency { get; set; }

        /// <summary>
        /// URL to the preview image.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public MediaFile Image { get; set; }

        /// <summary>
        /// A flag indicating whether the variant is the default for the product.
        /// </summary>
        [JsonProperty(PropertyName = "default_product_variation")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// true if the product is in stock, or false if not.
        /// </summary>
        [JsonProperty(PropertyName = "in_stock")]
        public bool IsInStock { get; set; }

        /// <summary>
        /// If the product is currently online. true if online false if not.
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// A flag indicating whether the variant is searchable.
        /// </summary>
        [JsonProperty(PropertyName = "searchable")]
        public SiteSpecific<bool> IsSearchable { get; set; }

        #endregion
    }
}
