using System.Collections.Generic;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Represents the basic structure of a sub-item.
    /// </summary>
    public abstract class BaseItem
    {
        #region Properties

        /// <summary>
        /// The tax of the product item after adjustments applying.
        /// </summary>
        [JsonProperty(PropertyName = "adjusted_tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdjustedTax { get; set; }

        /// <summary>
        /// The base price for the line item, which is the price of the unit before applying adjustments, in the purchase currency. The base price may be net or gross of tax depending on the configured taxation policy.
        /// </summary>
        [JsonProperty(PropertyName = "base_price")]
        public decimal BasePrice { get; set; }

        /// <summary>
        /// The item identifier. Use this to identify an item when updating the item quantity or creating a custom price adjustment for an item.
        /// </summary>
        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// The text describing the item in more detail.
        /// </summary>
        [JsonProperty(PropertyName = "item_text")]
        public string ItemText { get; set; }

        /// <summary>
        /// The price of the line item before applying any adjustments. If the line item is based on net pricing then the net price is returned. If the line item is based on gross pricing then the gross price is returned.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Array of price adjustments. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "price_adjustments")]
        public IEnumerable<PriceAdjustment> PriceAdjustments { get; set; }

        /// <summary>
        /// The price of the product line item after applying all product-level adjustments.
        /// </summary>
        /// <remarks>For net pricing the adjusted net price is returned. For gross pricing, the adjusted gross price is returned.</remarks>
        [JsonProperty(PropertyName = "price_after_item_discount")]
        public decimal PriceAfterItemDiscount { get; set; }

        /// <summary>
        /// The identifier of the shipment to which this item belongs.
        /// </summary>
        [JsonProperty(PropertyName = "shipment_id")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The tax of the product item before adjustments applying.
        /// </summary>
        [JsonProperty(PropertyName = "tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The price used to calculate the tax for this product item.
        /// </summary>
        [JsonProperty(PropertyName = "tax_basis", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TaxBasis { get; set; }

        /// <summary>
        /// The tax class ID for the product item or null if no tax class ID is associated with the product item.
        /// </summary>
        [JsonProperty(PropertyName = "tax_class_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxClassId { get; set; }

        /// <summary>
        /// The tax rate, which is the decimal tax rate to be applied to the product represented by this item.
        /// </summary>
        [JsonProperty(PropertyName = "tax_rate")]
        public decimal TaxRate { get; set; }

        #endregion
    }
}
