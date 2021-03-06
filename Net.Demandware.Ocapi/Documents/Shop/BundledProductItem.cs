﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a bundled product item data.
    /// </summary>
    public sealed class BundledProductItem
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
        /// The text describing the item in more detail.
        /// </summary>
        [JsonProperty(PropertyName = "item_text")]
        public string ItemText { get; set; }

        /// <summary>
        /// The id (SKU) of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_id", Required = Required.AllowNull)]
        [StringLength(100)]
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

        #endregion
    }
}
