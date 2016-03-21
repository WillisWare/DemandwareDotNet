using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseRequests
{
    /// <summary>
    /// Represents the basic structure of a payment card request.
    /// </summary>
    public abstract class BasePaymentCardRequest
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

        #endregion
    }
}
