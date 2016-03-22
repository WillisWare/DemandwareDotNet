using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product search refinement.
    /// </summary>
    public sealed class ProductSearchRefinement
    {
        #region Properties

        /// <summary>
        /// The id of the search refinement attribute.
        /// </summary>
        /// <remarks>In the case of an attribute refinement, this is the attribute id. Custom attributes are marked by the prefix "c_" (for example, "c_refinementColor"). In the case of a category refinement, the id must be "cgid". In the case of a price refinement, the id must be "price".</remarks>
        [JsonProperty(PropertyName = "attribute_id")]
        public string AttributeId { get; set; }

        /// <summary>
        /// The localized label of the refinement.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// The sorted array of refinement values. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<ProductSearchRefinementValue> Values { get; set; }

        #endregion
    }
}
