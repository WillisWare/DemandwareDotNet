using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing an A/B Test trigger.
    /// </summary>
    public sealed class AbTestTrigger
    {
        #region Properties

        /// <summary>
        /// The list of categories.
        /// </summary>
        /// <remarks>This is a modifiable attribute when trigger type is 'category_page_view' only.</remarks>
        [JsonProperty(PropertyName = "categories")]
        public IEnumerable<string> Categories { get; set; } = new List<string>();

        /// <summary>
        /// The flag indicating if the trigger is based on pipelines.
        /// </summary>
        /// <remarks>This is a computed attribute and cannot be modified.</remarks>
        [JsonProperty(PropertyName = "is_pipeline_based")]
        public bool IsPipelineBased { get; private set; }

        /// <summary>
        /// The list of pipeline name and start node combinations (for example, Account-Show).
        /// </summary>
        /// <remarks>This is a modifiable attribute when trigger type is 'pipeline_calls' only.</remarks>
        [JsonProperty(PropertyName = "pipeline_calls")]
        public IEnumerable<string> PipelineCalls { get; set; } = new List<string>();

        /// <summary>
        /// The type of the trigger.
        /// </summary>
        /// <remarks>Defaults to 'immediately' if not specified on create.</remarks>
        [DefaultValue("immediately")]
        [JsonProperty(PropertyName = "trigger_type", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonRequired]
        public string TriggerType { get; set; }

        #endregion
    }
}
