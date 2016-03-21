using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Shop;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseRequests
{
    /// <summary>
    /// Represents the basic structure of a payment instrument request.
    /// </summary>
    public abstract class BasePaymentInstrumentRequest
    {
        #region Properties

        /// <summary>
        /// The payment bank account.
        /// </summary>
        [JsonProperty(PropertyName = "payment_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentBankAccountRequest BankAccount { get; set; }

        /// <summary>
        /// The bank routing number.
        /// </summary>
        [JsonProperty(PropertyName = "bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(256)]
        public string BankRoutingNumber { get; set; }

        /// <summary>
        /// The gift certificate code.
        /// </summary>
        [JsonProperty(PropertyName = "gift_certificate_code")]
        [StringLength(256)]
        public string GiftCertificateCode { get; set; }

        /// <summary>
        /// The payment method id. Optional if a customer payment instrument id is specified.
        /// </summary>
        [JsonProperty(PropertyName = "payment_method_id")]
        [StringLength(256)]
        public string PaymentMethodId { get; set; }

        #endregion
    }
}
