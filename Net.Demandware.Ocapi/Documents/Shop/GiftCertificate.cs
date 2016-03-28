using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a gift certificate.
    /// </summary>
    public sealed class GiftCertificate : BaseGiftCertificate
    {
        #region Properties

        /// <summary>
        /// The gift certificate original amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The gift certificate balance.
        /// </summary>
        [JsonProperty(PropertyName = "balance")]
        public decimal Balance { get; set; }

        #endregion
    }
}
