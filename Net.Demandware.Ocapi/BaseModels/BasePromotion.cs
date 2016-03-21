using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    public class BasePromotion : BaseClass
    {
        #region Properties

        /// <summary>
        /// The localized call-out message of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "callout_msg")]
        public string CalloutMessage { get; set; }

        /// <summary>
        /// The unique ID of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_id")]
        public override string Id { get; set; }

        /// <summary>
        /// The URL addressing the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        #endregion
    }
}
