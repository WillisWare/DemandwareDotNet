using Net.Demandware.Ocapi.DataTypes;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
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
        public Localized<string> Description { get; set; }

        /// <summary>
        /// The localized name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public Localized<string> Name { get; set; }

        /// <summary>
        /// The localized page description.
        /// </summary>
        [JsonProperty(PropertyName = "page_description")]
        public Localized<string> PageDescription { get; set; }

        /// <summary>
        /// The localized page description.
        /// </summary>
        [JsonProperty(PropertyName = "page_keywords")]
        public Localized<string> PageKeywords { get; set; }

        /// <summary>
        /// The localized page title.
        /// </summary>
        [JsonProperty(PropertyName = "page_title")]
        public Localized<string> PageTitle { get; set; }

        #endregion
    }
}
