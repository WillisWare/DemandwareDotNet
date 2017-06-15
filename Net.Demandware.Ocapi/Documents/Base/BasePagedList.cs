using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Represents the structure of a paged list of items.
    /// </summary>
    /// <typeparam name="T">A type param containing the type of the list items.</typeparam>
    public class BasePagedList<T> : BasePagedResult<T>
    {
        #region Properties

        /// <summary>
        /// The list of expands set for the search request.
        /// </summary>
        /// <remarks>Expands are optional.</remarks>
        [JsonProperty(PropertyName = "expand", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Expand { get; set; } = new List<string>();

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        #endregion
    }
}
