using Net.Demandware.Ocapi.DataTypes;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a media file.
    /// </summary>
    public sealed class MediaFile
    {
        #region Properties

        /// <summary>
        /// The absolute URL with request protocol.
        /// </summary>
        [JsonProperty(PropertyName = "abs_url")]
        public string AbsoluteUrl { get; set; }

        /// <summary>
        /// The alternative image text.
        /// </summary>
        [JsonProperty(PropertyName = "alt")]
        public Localized<string> AlternateText { get; set; }

        /// <summary>
        /// The DIS base URL only for product images.
        /// </summary>
        [JsonProperty(PropertyName = "dis_base_url")]
        public string DISBaseUrl { get; set; }

        /// <summary>
        /// The raw media file path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// The image title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public Localized<string> Title { get; set; }

        #endregion
    }
}
