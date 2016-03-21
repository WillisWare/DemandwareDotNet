using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents payment card information.
    /// </summary>
    public sealed class PaymentCardRequest
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
        /// The payment card issue number.
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        [StringLength(4000)]
        public string Number { get; set; }

        /// <summary>
        /// The payment card security code.
        /// </summary>
        [JsonProperty(PropertyName = "security_code")]
        public string SecurityCode { get; set; }

        #endregion
    }
}
