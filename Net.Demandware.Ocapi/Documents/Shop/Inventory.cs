using System;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents inventory information of the current product for a particular inventory list.
    /// </summary>
    public sealed class Inventory : BaseClass
    {
        #region Properties

        /// <summary>
        /// The ats of the product. If it is infinity, the return value is 999999. The value can be overwritten by the OCAPI setting 'product.inventory.ats.max_threshold'.
        /// </summary>
        [JsonProperty(PropertyName = "ats")]
        public decimal AvailableToShip { get; set; }

        /// <summary>
        /// A flag indicating the date when the product will be in stock.
        /// </summary>
        [JsonProperty(PropertyName = "in_stock_date")]
        public DateTime InStockDate { get; set; }

        /// <summary>
        /// A flag indicating whether the product is back orderable.
        /// </summary>
        [JsonProperty(PropertyName = "backorderable")]
        public bool IsBackorderable { get; set; }

        /// <summary>
        /// A flag indicating whether at least one of products is available to sell.
        /// </summary>
        [JsonProperty(PropertyName = "orderable")]
        public bool IsOrderable { get; set; }

        /// <summary>
        /// A flag indicating whether the product is pre orderable.
        /// </summary>
        [JsonProperty(PropertyName = "preorderable")]
        public bool IsPreorderable { get; set; }

        /// <summary>
        /// The stock level of the product. If it is infinity, the return value is 999999. The value can be overwritten by the OCAPI setting 'product.inventory.stock_level.max_threshold'.
        /// </summary>
        [JsonProperty(PropertyName = "stock_level")]
        public decimal StockLevel { get; set; }

        #endregion
    }
}
