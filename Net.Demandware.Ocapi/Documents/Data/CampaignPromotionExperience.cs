using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing promotion properties that are needed for assigning/unassigning the promotion to/from a campaign.
    /// </summary>
    public sealed class CampaignPromotionExperience
    {
        #region Properties

        /// <summary>
        /// The ID of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_id")]
        [JsonRequired]
        [StringLength(256, MinimumLength = 1)]
        public string PromotionId { get; set; }

        #endregion
    }
}
