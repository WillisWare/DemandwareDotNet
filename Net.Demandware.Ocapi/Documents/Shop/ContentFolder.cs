using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a content folder.
    /// </summary>
    public sealed class ContentFolder : BasePageItem
    {
        #region Properties

        /// <summary>
        /// The array of content subfolders. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IEnumerable<ContentFolder> Folders { get; set; }

        /// <summary>
        /// The id of the parent content folder.
        /// </summary>
        [JsonProperty(PropertyName = "parent_folder_id")]
        public string ParentId { get; set; }

        #endregion
    }
}
