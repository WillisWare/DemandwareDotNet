using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a sorting rule properties that are needed for assigning/unassigning the sorting rule to a campaign.
    /// </summary>
    public sealed class CampaignSortingRuleExperience
    {
        #region Properties

        /// <summary>
        /// The id of the category that is assigned to the sorting rule.
        /// </summary>
        [JsonProperty(PropertyName = "category_id")]
        [JsonRequired]
        [StringLength(256, MinimumLength = 1)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The id of Sorting rule that is to be assigned to a campaign.
        /// </summary>
        [JsonProperty(PropertyName = "sorting_rule_id")]
        [JsonRequired]
        [StringLength(256, MinimumLength = 1)]
        public string SortingRuleId { get; set; }

        #endregion
    }
}
