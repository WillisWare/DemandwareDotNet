using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Exceptions
{
    /// <summary>
    /// Exception class representing the structure and content of an error response returned from a Demandware API call.
    /// </summary>
    public sealed class DemandwareException
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Fault document that defines the error.
        /// </summary>
        [JsonProperty("fault")]
        public Fault Fault { get; set; }

        /// <summary>
        /// Gets or sets the Demandware instance version that threw the error.
        /// </summary>
        [JsonProperty("_v")]
        public string Version { get; set; }

        #endregion
    }
}
