using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a customer payment card request.
    /// </summary>
    public class CustomerPaymentCardRequest : BasePaymentCardRequest
    {
        #region Properties

        /// <summary>
        /// The payment card type (for example, 'Visa').
        /// </summary>
        [JsonProperty(PropertyName = "card_type")]
        [StringLength(256)]
        public string CardType { get; set; }

        /// <summary>
        /// A flag indicating if the credit card is expired.
        /// </summary>
        [JsonProperty(PropertyName = "credit_card_expired")]
        public bool IsExpired { get; set; }

        /// <summary>
        /// The payment card issue number.
        /// </summary>
        [JsonProperty(PropertyName = "issue_number")]
        [StringLength(256)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// A credit card token.
        /// </summary>
        /// <remarks>If a credit card is tokenized, the token can be used to look up the credit card data at the token store.</remarks>
        [JsonProperty(PropertyName = "credit_card_token")]
        public string Token { get; set; }

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
