using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a campaign.
    /// </summary>
    public sealed class Campaign : BaseClass
    {
        #region Properties

        /// <summary>
        /// The array of assigned coupon IDs, not sorted.
        /// </summary>
        [JsonProperty(PropertyName = "coupons")]
        public IEnumerable<string> Coupons { get; set; }

        /// <summary>
        /// The array of assigned customer groups, not sorted.
        /// </summary>
        [JsonProperty(PropertyName = "customer_groups")]
        public IEnumerable<string> CustomerGroups { get; set; }

        /// <summary>
        /// The description of the campaign.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// The date that the Scenario ends.
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The ID of the campaign.
        /// </summary>
        [JsonProperty(PropertyName = "campaign_id", Required = Required.DisallowNull)]
        [StringLength(256, MinimumLength = 1)]
        public override string Id { get; set; }

        /// <summary>
        /// The enabled flag for campaign.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Link for convenience.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The array of assigned source code groups, not sorted.
        /// </summary>
        [JsonProperty(PropertyName = "source_code_groups")]
        public IEnumerable<string> SourceCodeGroups { get; set; }

        /// <summary>
        /// The date that the Scenario begins.
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }

        #endregion
    }
}
