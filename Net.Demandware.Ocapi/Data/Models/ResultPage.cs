using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents data that can be used to get the next and previous page of a Data API results object.
    /// </summary>
    public class ResultPage
    {
        #region Properties

        /// <summary>
        /// Returns the count of search hits to include in the page.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Returns the zero-based index of the first search hit in the page.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int StartIndex { get; set; }

        #endregion
    }
}
