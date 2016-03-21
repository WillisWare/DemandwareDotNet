using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a search refinement value.
    /// </summary>
    public sealed class ContentSearchRefinementValue
    {
        #region Properties

        /// <summary>
        /// The number of search hits (0 or more) when selecting the refinement value.
        /// </summary>
        [JsonProperty(PropertyName = "hit_count")]
        public int Count { get; set; }

        /// <summary>
        /// The localized description of the refinement value.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The localized label of the refinement value.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// The optional presentation id associated with the refinement value.
        /// </summary>
        /// <remarks>The presentation id can be used, for example, to associate an id with an HTML widget.</remarks>
        [JsonProperty(PropertyName = "presentation_id")]
        public string PresentationId { get; set; }

        /// <summary>
        /// The refinement value.
        /// </summary>
        /// <remarks>
        /// In the case of an attribute refinement, this is the bucket, the attribute value, or a value range.
        /// In the case of a content folder refinement, this is the folder id.
        /// </remarks>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// The array of hierarchical refinement values. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<ContentSearchRefinementValue> Values { get; set; }

        #endregion
    }
}
