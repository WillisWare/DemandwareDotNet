using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a product item.
    /// </summary>
    public class ProductItem : BaseItem
    {
        #region Properties

        /// <summary>
        /// The array of bundled product items. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "bundled_product_items")]
        public IEnumerable<BundledProductItem> BundledProductItems { get; set; }

        /// <summary>
        /// The inventory list id associated with this item.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_id")]
        [StringLength(256)]
        public string InventoryId { get; set; }

        /// <summary>
        /// A flag indicating whether the product item is a bonus.
        /// </summary>
        [JsonProperty(PropertyName = "bonus_product_line_item")]
        public bool IsBonus { get; set; }

        /// <summary>
        /// The array of option items. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "option_items")]
        public IEnumerable<OptionItem> OptionItems { get; set; }

        /// <summary>
        /// The price of this product line item after considering all dependent price adjustments and prorating all order-level price adjustments.
        /// </summary>
        /// <remarks>For net pricing the net price is returned. For gross pricing, the gross price is returned.</remarks>
        [JsonProperty(PropertyName = "price_after_order_discount")]
        public decimal PriceAfterOrderDiscount { get; set; }

        /// <summary>
        /// The id (SKU) of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity of the products represented by this item.
        /// </summary>
        [JsonProperty(PropertyName = "quantity", Required = Required.AllowNull)]
        [Range(typeof(decimal), "0.0", "999.0")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The reference to the related shipping item if it exists.
        /// </summary>
        /// <remarks>This is the case if for example when a surcharge is defined for individual products using a particular a shipping method.</remarks>
        [JsonProperty(PropertyName = "shipping_item_id")]
        public string ShippingItemId { get; set; }

        #endregion
    }
}
