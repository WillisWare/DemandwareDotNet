using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing markup text.
    /// </summary>
    public sealed class MarkupText
    {
        #region Properties

        /// <summary>
        /// The rendered HTML.
        /// </summary>
        [JsonProperty(PropertyName = "markup")]
        public string Markup { get; set; }

        /// <summary>
        /// The raw markup text.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        #endregion
    }
}
