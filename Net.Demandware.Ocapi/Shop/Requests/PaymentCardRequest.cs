using Net.Demandware.Ocapi.BaseRequests;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Requests
{
    /// <summary>
    /// Represents payment card information.
    /// </summary>
    public sealed class PaymentCardRequest : BasePaymentCardRequest
    {
        #region Properties

        /// <summary>
        /// The payment card security code.
        /// </summary>
        [JsonProperty(PropertyName = "security_code")]
        public string SecurityCode { get; set; }

        #endregion
    }
}
