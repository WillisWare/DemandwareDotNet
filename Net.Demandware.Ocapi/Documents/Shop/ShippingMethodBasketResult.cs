using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a result containing an array of shipping methods for each shipment of the basket.
    /// </summary>
    public sealed class ShippingMethodBasketResult
    {
        #region Properties

        /// <summary>
        /// The applicable shipping methods for each shipment of the basket represented as a map with shipment id/applicable shipping methods for the shipment pairs.
        /// </summary>
        [JsonProperty(PropertyName = "basket_shipping_methods")]
        public IDictionary<string, ShippingMethodResult> BasketShippingMethods { get; set; }

        #endregion
    }
}
