using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents an image.
    /// </summary>
    public sealed class Image : SimpleLink
    {
        #region Properties

        /// <summary>
        /// The localized alternative text of the image.
        /// </summary>
        [JsonProperty(PropertyName = "alt")]
        public string AlternateText { get; set; }

        /// <summary>
        /// Base URL for dynamic image service address.
        /// </summary>
        /// <remarks>This is only shown, if the image is stored on the server and DIS is enabled.</remarks>
        [JsonProperty(PropertyName = "dis_base_link")]
        public string BaseLink { get; set; }

        /// <summary>
        /// The localized title of the image.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        #endregion
    }
}
