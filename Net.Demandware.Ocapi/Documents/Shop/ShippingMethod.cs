using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a shipping method.
    /// </summary>
    public sealed class ShippingMethod : BaseClass
    {
        #region Properties

        /// <summary>
        /// The localized description of the shipping method.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The localized name of the shipping method.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The shipping cost total, including shipment level costs and product level fix and surcharge costs.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The array of active customer shipping promotions for this shipping method. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_promotions")]
        public IEnumerable<ShippingPromotion> Promotions { get; set; }

        #endregion
    }
}
