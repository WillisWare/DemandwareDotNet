using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseResults
{
    /// <summary>
    /// Represents the basic structure of a result document.
    /// </summary>
    /// <typeparam name="T">A type param containing the type of the Data collection.</typeparam>
    public abstract class BaseResult<T>
    {
        #region Properties

        [JsonProperty(PropertyName = "count", NullValueHandling = NullValueHandling.Ignore)]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "data")]
        public virtual IEnumerable<T> Data { get; set; }

        [JsonProperty(PropertyName = "total", NullValueHandling = NullValueHandling.Ignore)]
        public int Total { get; set; }

        #endregion
    }
}
