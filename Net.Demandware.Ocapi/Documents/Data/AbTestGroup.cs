using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing an A/B Test Group.
    /// </summary>
    public sealed class AbTestGroup : BaseClass
    {
        #region Properties

        /// <summary>
        /// Test Group percentage allocation.
        /// </summary>
        [JsonProperty(PropertyName = "allocation", NullValueHandling = NullValueHandling.Ignore)]
        public int Allocation { get; set; }

        /// <summary>
        /// Test Group description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// Flag to determine if this Test Group is a customer experience.
        /// </summary>
        [JsonProperty(PropertyName = "custom_experience")]
        public bool IsCustomExperience { get; set; }

        #endregion
    }
}
