using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product option.
    /// </summary>
    public sealed class Option : BaseClass
    {
        #region Properties

        /// <summary>
        /// The localized description of the option.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The URL to the option image.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// The localized name of the option.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The array of option values. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<OptionValue> Values { get; set; }

        #endregion
    }
}
