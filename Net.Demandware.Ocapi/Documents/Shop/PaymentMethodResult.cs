using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a result containing an array of payment methods applicable for a basket.
    /// </summary>
    public sealed class PaymentMethodResult
    {
        #region Properties

        /// <summary>
        /// The applicable payment methods.
        /// </summary>
        [JsonProperty(PropertyName = "applicable_payment_methods")]
        public IEnumerable<PaymentMethod> PaymentMethods { get; set; }

        #endregion
    }
}
