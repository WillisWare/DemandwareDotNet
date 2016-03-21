using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a recommendation.
    /// </summary>
    public sealed class Recommendation
    {
        #region Properties

        /// <summary>
        /// The localized callout message of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "callout_msg")]
        public string CalloutMessage { get; set; }

        /// <summary>
        /// The image of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        /// <summary>
        /// The recommended item id of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "recommended_item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// The recommended item link of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "recommended_item_link")]
        public string Link { get; set; }

        /// <summary>
        /// The localized long description of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "long_description")]
        public string LongDescription { get; set; }

        /// <summary>
        /// The localized name of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The localized short description of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The recommendation type of the recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "recommendation_type")]
        public RecommendationType Type { get; set; }

        #endregion
    }
}
