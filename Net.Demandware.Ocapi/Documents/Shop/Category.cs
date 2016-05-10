using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a category.
    /// </summary>
    public sealed class Category : BaseClass
    {
        #region Properties

        /// <summary>
        /// Array of subcategories. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IEnumerable<Category> Categories { get; set; }

        /// <summary>
        /// The localized description of the category.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The URL to the category image.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// The localized name of the category.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The localized page description of the category.
        /// </summary>
        [JsonProperty(PropertyName = "page_description")]
        public string PageDescription { get; set; }

        /// <summary>
        /// The localized page keywords of the category.
        /// </summary>
        [JsonProperty(PropertyName = "page_keywords")]
        public string PageKeywords { get; set; }

        /// <summary>
        /// The localized page title of the category.
        /// </summary>
        [JsonProperty(PropertyName = "page_title")]
        public string PageTitle { get; set; }

        /// <summary>
        /// The id of the parent category.
        /// </summary>
        [JsonProperty(PropertyName = "parent_category_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// The URL to the category thumbnail.
        /// </summary>
        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        #endregion
    }
}
