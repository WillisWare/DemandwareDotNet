using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents an order payment card request.
    /// </summary>
    public sealed class OrderPaymentCardRequest : CustomerPaymentCardRequest
    {
        #region Properties

        /// <summary>
        /// The security code for the payment card.
        /// </summary>
        [JsonProperty(PropertyName = "security_code")]
        [StringLength(4)]
        public string SecurityCode { get; set; }

        #endregion
    }
}
