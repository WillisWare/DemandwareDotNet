using Net.Demandware.Ocapi.DataTypes;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Document representing a promotion link.
    /// </summary>
    public sealed class PromotionLink
    {
        #region Properties

        /// <summary>
        /// The localized call-out message of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "callout_msg")]
        public Localized<string> CalloutMessage { get; set; }

        /// <summary>
        /// The localized name of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public Localized<string> Name { get; set; }

        /// <summary>
        /// The unique id of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_id")]
        public string PromotionId { get; set; }

        #endregion
    }
}
