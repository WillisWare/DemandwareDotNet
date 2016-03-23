using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi
{
    /// <summary>
    /// Represents a link to another resource.
    /// </summary>
    public class SimpleLink
    {
        #region Properties

        /// <summary>
        /// The link to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "link", Required = Required.Always)]
        [MinLength(1)]
        public string Link { get; set; }

        #endregion
    }
}
