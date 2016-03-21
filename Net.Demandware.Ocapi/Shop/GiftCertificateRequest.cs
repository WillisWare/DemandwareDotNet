using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents gift certificate request data.
    /// </summary>
    public sealed class GiftCertificateRequest
    {
        #region Properties

        /// <summary>
        /// The gift certificate code.
        /// </summary>
        [JsonProperty(PropertyName = "gift_certificate_code")]
        public string Code { get; set; }

        #endregion
    }
}
