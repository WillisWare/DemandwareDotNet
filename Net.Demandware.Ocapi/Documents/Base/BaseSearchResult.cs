using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Represents the basic structure of a search result document.
    /// </summary>
    /// <typeparam name="T">A type param containing the type of the Data collection.</typeparam>
    public abstract class BaseSearchResult<T> : BaseResult<T>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<T> Data { get; set; }

        #endregion
    }
}
