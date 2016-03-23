using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a content asset.
    /// </summary>
    public sealed class ContentAsset : BasePageItem
    {
        #region Properties

        /// <summary>
        /// The ID of the classification folder, which shows that the assignment from this content asset to the folder is the 'default' one.
        /// </summary>
        [JsonProperty(PropertyName = "classification_folder_id")]
        public string ClassificationFolderId { get; set; }

        /// <summary>
        /// The link to the classification folder, which shows that the assignment from this content asset to the folder is the 'default' one.
        /// </summary>
        [JsonProperty(PropertyName = "classification_folder_link")]
        public string ClassificationFolderLink { get; set; }

        /// <summary>
        /// Is the asset online?
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// Is the asset searchable?
        /// </summary>
        [JsonProperty(PropertyName = "searchable")]
        public bool IsSearchable { get; set; }

        /// <summary>
        /// The status if the content asset is included into the sitemap (either 0 or 1).
        /// </summary>
        /// <remarks>Why isn't this a Boolean??</remarks>
        [JsonProperty(PropertyName = "site_map_included")]
        [Range(0, 1)]
        public int IsSiteMapIncluded { get; set; }

        /// <summary>
        /// The link to the content asset resource.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The localized content asset page url.
        /// </summary>
        [JsonProperty(PropertyName = "page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// The content assets change frequency needed for the sitemap creation (always, hourly, daily, weekly, monthly, yearly, never).
        /// </summary>
        [JsonProperty(PropertyName = "site_map_change_frequency")]
        public string SiteMapChangeFrequency { get; set; }

        /// <summary>
        /// The content assets priority needed for the sitemap creation (0.0 for no priority defined).
        /// </summary>
        [JsonProperty(PropertyName = "site_map_priority")]
        public decimal SiteMapPriority { get; set; }

        /// <summary>
        /// The rendering template.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public string Template { get; set; }

        #endregion
    }
}
