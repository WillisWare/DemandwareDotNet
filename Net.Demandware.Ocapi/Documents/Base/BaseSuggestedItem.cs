using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Represents the basic structure of a suggested item.
    /// </summary>
    public abstract class BaseSuggestedItem : BaseClass
    {
        #region Properties

        /// <summary>
        /// The URL addressing the item.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The localized name of the item.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        #endregion
    }
}
