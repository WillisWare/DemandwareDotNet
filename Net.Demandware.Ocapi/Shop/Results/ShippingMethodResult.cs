using System.Collections.Generic;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Results
{
    /// <summary>
    /// Represents a result containing an array of shipping methods.
    /// </summary>
    public sealed class ShippingMethodResult
    {
        #region Properties

        /// <summary>
        /// The applicable shipping method documents.
        /// </summary>
        [JsonProperty(PropertyName = "applicable_shipping_methods")]
        public IEnumerable<ShippingMethod> ApplicableShippingMethods { get; set; }

        /// <summary>
        /// The default shipping method.
        /// </summary>
        [JsonProperty(PropertyName = "default_shipping_method_id")]
        public string DefaultShippingMethodId { get; set; }

        #endregion
    }
}
