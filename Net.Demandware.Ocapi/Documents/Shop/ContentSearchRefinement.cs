using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a search refinement attribute.
    /// </summary>
    public sealed class ContentSearchRefinement : BaseClass
    {
        #region Properties

        /// <summary>
        /// The id of the search refinement attribute.
        /// </summary>
        /// <remarks>
        /// In the case of an attribute refinement, this is the attribute id.
        /// Custom attributes are marked by the prefix "c_".
        /// </remarks>
        [JsonProperty(PropertyName = "attribute_id")]
        public override string Id { get; set; }

        /// <summary>
        /// The localized label of the refinement.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// The sorted array of refinement values. The array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<ContentSearchRefinementValue> Values { get; set; }

        #endregion
    }
}
