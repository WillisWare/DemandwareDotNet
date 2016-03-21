using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents an order payment instrument.
    /// </summary>
    public sealed class OrderPaymentInstrument : BasePaymentInstrument
    {
        #region Properties

        /// <summary>
        /// The payment transaction amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The etag to show the last update status.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string ETag { get; set; }

        #endregion
    }
}
