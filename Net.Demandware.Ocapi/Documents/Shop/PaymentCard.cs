using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a payment card.
    /// </summary>
    public sealed class PaymentCard
    {
        #region Properties

        /// <summary>
        /// The month when the payment card expires.
        /// </summary>
        [JsonProperty(PropertyName = "expiration_month")]
        [Range(1, 12)]
        public int ExpirationMonth { get; set; }

        /// <summary>
        /// The year when the payment card expires.
        /// </summary>
        [JsonProperty(PropertyName = "expiration_year")]
        public int ExpirationYear { get; set; }

        /// <summary>
        /// The payment card holder.
        /// </summary>
        [JsonProperty(PropertyName = "holder")]
        [StringLength(256)]
        public string Holder { get; set; }

        /// <summary>
        /// A flag indicating if the credit card is expired.
        /// </summary>
        [JsonProperty(PropertyName = "credit_card_expired")]
        public bool IsExpired { get; set; }

        /// <summary>
        /// The last digits of credit card number.
        /// </summary>
        [JsonProperty(PropertyName = "number_last_digits")]
        [StringLength(4000)]
        public string LastDigits { get; set; }

        /// <summary>
        /// The payment card issue number.
        /// </summary>
        [JsonProperty(PropertyName = "issue_number")]
        [StringLength(256)]
        public string Number { get; set; }

        /// <summary>
        /// The masked credit card number.
        /// </summary>
        [JsonProperty(PropertyName = "masked_number")]
        [StringLength(4000)]
        public string NumberMasked { get; set; }

        /// <summary>
        /// A credit card token. If a credit card is tokenized, the token can be used to look up the credit card data at the token store.
        /// </summary>
        [JsonProperty(PropertyName = "credit_card_token")]
        public string Token { get; set; }

        /// <summary>
        /// The payment card type (for example, 'Visa').
        /// </summary>
        [JsonProperty(PropertyName = "card_type")]
        [StringLength(256)]
        public string Type { get; set; }

        /// <summary>
        /// The payment card valid from month.
        /// </summary>
        [JsonProperty(PropertyName = "valid_from_month")]
        [Range(1, 12)]
        public int ValidMonth { get; set; }

        /// <summary>
        /// The payment card valid from year.
        /// </summary>
        [JsonProperty(PropertyName = "valid_from_year")]
        public int ValidYear { get; set; }

        #endregion
    }
}
