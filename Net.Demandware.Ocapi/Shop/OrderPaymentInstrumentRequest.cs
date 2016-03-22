using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents an order payment instrument request.
    /// </summary>
    public sealed class OrderPaymentInstrumentRequest : CustomerPaymentInstrumentRequest
    {
        #region Properties

        /// <summary>
        /// The payment transaction amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// A flag indicating whether a related customer payment instrument should be created.
        /// </summary>
        /// <remarks>The CustomerPaymentInstrument is only created when the OrderPaymentInstrument was authorized successfully.</remarks>
        [JsonProperty(PropertyName = "create_customer_payment_instrument")]
        public bool CreateCustomerPaymentInstrument { get; set; }

        /// <summary>
        /// The id of a customer payment instrument.
        /// </summary>
        /// <remarks>If present in the request only the CVN and the amount will be considered from this request.</remarks>
        [JsonProperty(PropertyName = "customer_payment_instrument_id")]
        public string CustomerPaymentInstrumentId { get; set; }

        #endregion
    }
}
