using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Represents the basic structure of a page item.
    /// </summary>
    public abstract class BasePageItem : BaseClass
    {
        #region Properties

        /// <summary>
        /// The localized description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The localized name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The localized page description.
        /// </summary>
        [JsonProperty(PropertyName = "page_description")]
        public string PageDescription { get; set; }

        /// <summary>
        /// The localized page description.
        /// </summary>
        [JsonProperty(PropertyName = "page_keywords")]
        public string PageKeywords { get; set; }

        /// <summary>
        /// The localized page title.
        /// </summary>
        [JsonProperty(PropertyName = "page_title")]
        public string PageTitle { get; set; }

        #endregion
    }
}
