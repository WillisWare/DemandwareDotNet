using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Represents the basic structure of a paged result document.
    /// </summary>
    /// <typeparam name="T">A type param containing the type of the Data collection.</typeparam>
    public abstract class BasePagedResult<T> : BaseResult<T>
    {
        #region Properties

        /// <summary>
        /// The URL of the next result page.
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

        /// <summary>
        /// The URL of the previous result page.
        /// </summary>
        [JsonProperty(PropertyName = "previous")]
        public string Previous { get; set; }

        /// <summary>
        /// The zero-based index of the first search hit to include in the result.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int StartIndex { get; set; }

        #endregion
    }
}
