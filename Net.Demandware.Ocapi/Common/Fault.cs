using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Common
{
    /// <summary>
    /// Represents a fault message that is returned whenever the HTTP status code is greater than or equal to 400 (which indicates an error).
    /// </summary>
    public sealed class Fault
    {
        #region Properties

        /// <summary>
        /// A map that provides fault arguments.
        /// </summary>
        /// <remarks>Data can be used to provide error messages on the client side.</remarks>
        [JsonProperty(PropertyName = "arguments", NullValueHandling = NullValueHandling.Include)]
        public IDictionary<string, object> Arguments { get; set; }

        /// <summary>
        /// The message text of the Java exception.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The name of the Java exception.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        #endregion
    }
}
