using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a suggested category.
    /// </summary>
    public sealed class SuggestedCategory : BaseSuggestedItem
    {
        #region Properties

        /// <summary>
        /// The name of the parent category.
        /// </summary>
        [JsonProperty(PropertyName = "parent_category_name")]
        public string ParentCategoryName { get; set; }

        #endregion
    }
}
