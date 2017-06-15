using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a slot configuration properties that are needed for assigning/unassigning the slot configuration to a campaign.
    /// </summary>
    public sealed class CampaignSlotConfigurationExperience
    {
        #region Properties

        /// <summary>
        /// The context ID.
        /// </summary>
        [JsonProperty(PropertyName = "context_id")]
        public string ContextId { get; set; }

        /// <summary>
        /// The context type.
        /// </summary>
        [JsonProperty(PropertyName = "context_type")]
        [JsonRequired]
        public string ContextType { get; set; }

        /// <summary>
        /// The slot configuration ID.
        /// </summary>
        [JsonProperty(PropertyName = "slot_configuration_id")]
        [JsonRequired]
        [StringLength(256, MinimumLength = 1)]
        public string SlotConfigurationId { get; set; }

        /// <summary>
        /// The slot ID.
        /// </summary>
        [JsonProperty(PropertyName = "slot_id")]
        [JsonRequired]
        [StringLength(256, MinimumLength = 1)]
        public string SlotId { get; set; }

        #endregion
    }
}
