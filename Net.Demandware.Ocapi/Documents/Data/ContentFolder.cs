using System.ComponentModel;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a content folder.
    /// </summary>
    public sealed class ContentFolder : BasePageItem
    {
        #region Properties

        /// <summary>
        /// A flag indicating whether the folder in online (default is false).
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        [DefaultValue(false)]
        public bool IsOnline { get; set; }

        /// <summary>
        /// The link to the content folder resource.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The localized content folder page url.
        /// </summary>
        [JsonProperty(PropertyName = "page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// The id of the parent content folder.
        /// </summary>
        [JsonProperty(PropertyName = "parent_folder_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// The URL to the parent content folder.
        /// </summary>
        [JsonProperty(PropertyName = "parent_link")]
        public string ParentLink { get; set; }

        /// <summary>
        /// The URL to the parent content folder.
        /// </summary>
        [JsonProperty(PropertyName = "sub_folders_link")]
        public string SubFoldersLink { get; set; }

        /// <summary>
        /// The rendering template.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public string Template { get; set; }

        #endregion
    }
}
