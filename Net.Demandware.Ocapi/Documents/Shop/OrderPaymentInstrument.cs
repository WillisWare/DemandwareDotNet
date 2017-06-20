using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
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
        /// The authorization status of the payment transaction.
        /// </summary>
        [JsonProperty(PropertyName = "authorization_status")]
        public Status Status { get; set; }

        #endregion
    }
}
