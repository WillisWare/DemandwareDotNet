using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Represents the basic, common properties of an OCAPI document.
    /// </summary>
    public abstract class BaseClass
    {
        #region Properties

        /// <summary>
        /// The document's custom attributes.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> CustomAttributes { get; set; }

        /// <summary>
        /// The document's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.DisallowNull)]
        [StringLength(100, MinimumLength = 1)]
        public virtual string Id { get; set; }

        /// <summary>
        /// The document's OCAPI document type.
        /// </summary>
        [JsonProperty(PropertyName = "_type", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Type { get; set; }

        /// <summary>
        /// The document's OCAPI version.
        /// </summary>
        [JsonProperty(PropertyName = "_v", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        #endregion
    }
}
