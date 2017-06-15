using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing an A/B Test.
    /// </summary>
    public sealed class AbTest : BaseClass
    {
        #region Properties

        /// <summary>
        /// The list of customer group ids assigned to the A/B Test.
        /// </summary>
        /// <remarks>Defaults to 'Everyone' if not specified on create.</remarks>
        [JsonProperty(PropertyName = "customer_groups")]
        [JsonRequired]
        public IEnumerable<string> CustomerGroups { get; set; } = new List<string>(50);

        /// <summary>
        /// The optional description of the A/B Test.
        /// </summary>
        [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// The optional list of email addresses to send A/B Test results.
        /// </summary>
        [JsonProperty(PropertyName = "email_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> EmailAddresses { get; set; } = new List<string>(50);

        /// <summary>
        /// The date that the A/B Test ends.
        /// </summary>
        /// <remarks>Defaults to two weeks from creation date if both start and end dates are not specified on create.</remarks>
        [JsonProperty(PropertyName = "end_date")]
        [JsonRequired]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The participant expiration type of the A/B Test.
        /// </summary>
        /// <remarks>Defaults to 'never' if not specified on create.</remarks>
        [DefaultValue("never")]
        [JsonProperty(PropertyName = "expiration_type")]
        [JsonRequired]
        public string ExpirationType { get; set; }

        /// <summary>
        /// The flag representing the enabled state of the A/B Test.
        /// </summary>
        /// <remarks>Defaults to false if not specified on create.</remarks>
        [JsonProperty(PropertyName = "enabled", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonRequired]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The flag representing the paused state of the A/B Test.
        /// </summary>
        /// <remarks>Defaults to false if not specified on create.</remarks>
        [JsonProperty(PropertyName = "paused")]
        public bool IsPaused { get; set; }

        /// <summary>
        /// The key metric that is most important to the A/B Test, among the metrics collected.
        /// </summary>
        /// <remarks>Defaults to 'Revenue' if not specified from test participant activity.</remarks>
        [DefaultValue("Revenue")]
        [JsonProperty(PropertyName = "key_metric_id")]
        [JsonRequired]
        public string KeyMetricId { get; set; }

        /// <summary>
        /// The URL to get the A/B test.
        /// </summary>
        /// <remarks>This is a computed attribute and cannot be modified.</remarks>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; private set; }

        /// <summary>
        /// The date that the A/B Test begins.
        /// </summary>
        /// <remarks>Defaults to a week from creation date if both start and end dates are not specified on create.</remarks>
        [JsonProperty(PropertyName = "start_date")]
        [JsonRequired]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The optional list of tags to group similar A/B Tests so that they can be searched easily.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IEnumerable<string> Tags { get; set; } = new List<string>(50);

        /// <summary>
        /// Test Groups created for an A/B Test.
        /// </summary>
        /// <remarks>This is a read only attribute for now.</remarks>
        [JsonProperty(PropertyName = "test_groups")]
        public IEnumerable<AbTestGroup> TestGroups { get; private set; } = new List<AbTestGroup>();

        /// <summary>
        /// The trigger that allows the test participant to be considered for an A/B Test.
        /// </summary>
        [JsonProperty(PropertyName = "trigger")]
        [JsonRequired]
        public AbTestTrigger Trigger { get; set; }

        #endregion
    }
}
