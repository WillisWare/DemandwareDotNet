using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Common
{
    /// <summary>
    /// Represents an optional flash message.
    /// </summary>
    public sealed class Flash
    {
        #region Properties

        /// <summary>
        /// An optional map containing details about this message.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [MaxLength(10)]
        public IDictionary<string, object> Details { get; set; }

        /// <summary>
        /// A short message with information for the user.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        [StringLength(400)]
        public string Message { get; set; }

        /// <summary>
        /// A reference to an element in the document in the form of a path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        [StringLength(200)]
        public string Path { get; set; }

        /// <summary>
        /// The type of the message.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.DisallowNull)]
        [StringLength(100)]
        public string Type { get; set; }

        #endregion
    }
}
