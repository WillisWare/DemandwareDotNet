using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Represents the basic structure of a result document.
    /// </summary>
    /// <typeparam name="T">A type param containing the type of the Data collection.</typeparam>
    public abstract class BaseResult<T>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the number of results in this set.
        /// </summary>
        [JsonProperty(PropertyName = "count", NullValueHandling = NullValueHandling.Ignore)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the data collection for the result.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public virtual IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Gets or sets the total number of results.
        /// </summary>
        [JsonProperty(PropertyName = "total", NullValueHandling = NullValueHandling.Ignore)]
        public int Total { get; set; }

        #endregion
    }
}
