using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a basket payment instrument request.
    /// </summary>
    public sealed class BasketPaymentInstrumentRequest : BasePaymentInstrumentRequest
    {
        #region Properties

        /// <summary>
        /// The payment transaction amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The payment card.
        /// </summary>
        [JsonProperty(PropertyName = "payment_card", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentCardRequest CreditCard { get; set; }

        #endregion
    }
}
