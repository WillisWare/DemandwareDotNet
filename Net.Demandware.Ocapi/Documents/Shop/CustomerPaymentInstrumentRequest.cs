using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a customer payment instrument request.
    /// </summary>
    public class CustomerPaymentInstrumentRequest : BasePaymentInstrumentRequest
    {
        #region Properties

        /// <summary>
        /// The customer payment card.
        /// </summary>
        [JsonProperty(PropertyName = "payment_card", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerPaymentCardRequest CreditCard { get; set; }

        #endregion
    }
}
