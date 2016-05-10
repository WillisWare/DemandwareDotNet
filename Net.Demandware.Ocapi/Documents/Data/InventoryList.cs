using System.Collections.Generic;
using System.ComponentModel;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents an inventory list.
    /// </summary>
    public sealed class InventoryList : BaseClass
    {
        #region Properties

        /// <summary>
        /// The list of sites this inventory list is assigned to.
        /// </summary>
        /// <remarks>The assigned sites is a computed attribute, and cannot be directly modified.</remarks>
        [JsonProperty(PropertyName = "assigned_sites")]
        public IEnumerable<string> AssignedSites { get; set; }

        /// <summary>
        /// The user supplied description of this instance.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// True if the inventory list is used in bundle inventory only.
        /// </summary>
        /// <remarks>The default value is false if not specified.</remarks>
        [JsonProperty(PropertyName = "use_bundle_inventory_only")]
        [DefaultValue(false)]
        public bool IsBundleOnly { get; set; }

        /// <summary>
        /// True if the default for the inventory list is to be in stock.
        /// </summary>
        /// <remarks>The default value is false if not specified.</remarks>
        [JsonProperty(PropertyName = "default_in_stock")]
        [DefaultValue(false)]
        public bool IsInStockByDefault { get; set; }

        /// <summary>
        /// URL that is used to get this instance.
        /// </summary>
        /// <remarks>The URL is a computed attribute, and cannot be modified.</remarks>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// True if the on order flag is enabled.
        /// </summary>
        /// <remarks>The default value is false if not specified.</remarks>
        [JsonProperty(PropertyName = "on_order_inventory_enabled")]
        [DefaultValue(false)]
        public bool OnOrderFlagEnabled { get; set; }

        #endregion
    }
}
