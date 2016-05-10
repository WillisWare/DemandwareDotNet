using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Shop;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Represents the basic structure of a payment instrument.
    /// </summary>
    public abstract class BasePaymentInstrument : BaseClass
    {
        #region Properties

        /// <summary>
        /// The payment bank account.
        /// </summary>
        [JsonProperty(PropertyName = "payment_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentBankAccount BankAccount { get; set; }

        /// <summary>
        /// The bank routing number.
        /// </summary>
        [JsonProperty(PropertyName = "bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(256)]
        public string BankRoutingNumber { get; set; }

        /// <summary>
        /// The payment card.
        /// </summary>
        [JsonProperty(PropertyName = "payment_card", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentCard CreditCard { get; set; }

        /// <summary>
        /// The masked gift certificate code.
        /// </summary>
        [JsonProperty(PropertyName = "masked_gift_certificate_code")]
        public string GiftCertificateCodeMasked { get; set; }

        /// <summary>
        /// The payment instrument ID.
        /// </summary>
        [JsonProperty(PropertyName = "payment_instrument_id")]
        public override string Id { get; set; }

        /// <summary>
        /// The payment method id. Optional if a customer payment instrument id is specified.
        /// </summary>
        [JsonProperty(PropertyName = "payment_method_id")]
        [StringLength(256)]
        public string PaymentMethodId { get; set; }

        #endregion
    }
}
