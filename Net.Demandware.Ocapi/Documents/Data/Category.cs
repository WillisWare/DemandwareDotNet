using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a category.
    /// </summary>
    public sealed class Category : BasePageItem
    {
        #region Properties

        /// <summary>
        /// The id of the catalog that contains it.
        /// </summary>
        [JsonProperty(PropertyName = "catalog_id")]
        public string CatalogId { get; set; }

        /// <summary>
        /// The array of sub categories for the category.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        /// <summary>
        /// Returns the value of attribute 'creationDate'.
        /// </summary>
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The name of the category image.
        /// </summary>
        /// <remarks>The URL to the image is computed.</remarks>
        [JsonProperty(PropertyName = "image")]
        [StringLength(256, MinimumLength = 1)]
        public string Image { get; set; }

        /// <summary>
        /// The online status of the category determines if it is visible in the storefront.
        /// </summary>
        /// <remarks>Defaults to false if not specified on create.</remarks>
        [JsonProperty(PropertyName = "online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// The URL to get the category.
        /// </summary>
        /// <remarks>This is a computed attribute and cannot be modified.</remarks>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; private set; }

        /// <summary>
        /// Returns the value of attribute 'lastModified'.
        /// </summary>
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The id of the parent category.
        /// </summary>
        /// <remarks>Defaults to root if not specified on create.</remarks>
        [JsonProperty(PropertyName = "parent_category_id")]
        [StringLength(256, MinimumLength = 1)]
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// The position of the category determines the display order in the storefront.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public double Position { get; set; }

        /// <summary>
        /// The name of the category thumbnail.
        /// </summary>
        /// <remarks>The URL to the thumbnail is computed.</remarks>
        [JsonProperty(PropertyName = "thumbnail")]
        [StringLength(256, MinimumLength = 1)]
        public string Thumbnail { get; set; }

        #endregion
    }
}
