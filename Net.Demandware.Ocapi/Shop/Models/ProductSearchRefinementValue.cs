using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product search refinement value.
    /// </summary>
    public sealed class ProductSearchRefinementValue
    {
        #region Properties

        /// <summary>
        /// The localized description of the refinement value.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The number of search hits when selecting the refinement value. Can be 0.
        /// </summary>
        [JsonProperty(PropertyName = "hit_count")]
        public int HitCount { get; set; }

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
        /// <remarks>In the case of an attribute refinement, this is the bucket, the attribute value, or a value range. In the case of a category refinement, this is the category id. In the case of a price refinement,k this is the price range. Ranges are enclosed by parentheses and separated by ".."; for example, "(100..999)" and "(Aa..Fa)" are valid ranges.</remarks>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// The array of hierarchical refinement values. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<ProductSearchRefinementValue> Values { get; set; }

        #endregion
    }
}
