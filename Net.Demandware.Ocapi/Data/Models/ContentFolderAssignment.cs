using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a content folder assignment.
    /// </summary>
    public sealed class ContentFolderAssignment
    {
        #region Properties

        /// <summary>
        /// The content id.
        /// </summary>
        [JsonProperty(PropertyName = "content_id")]
        [StringLength(256)]
        public string ContentId { get; set; }

        /// <summary>
        /// The content link.
        /// </summary>
        [JsonProperty(PropertyName = "content_link")]
        public string ContentLink { get; set; }

        /// <summary>
        /// The folder id.
        /// </summary>
        [JsonProperty(PropertyName = "folder_id")]
        [StringLength(256)]
        public string FolderId { get; set; }

        /// <summary>
        /// The folder link.
        /// </summary>
        [JsonProperty(PropertyName = "folder_link")]
        public string FolderLink { get; set; }

        /// <summary>
        /// A flag indicating whether the assignment is the default one.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public bool IsDefault { get; set; }

        #endregion
    }
}
