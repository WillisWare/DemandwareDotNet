using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents an option value.
    /// </summary>
    public sealed class OptionValue : BaseClass
    {
        #region Properties

        /// <summary>
        /// A flag indicating whether this option value is the default one.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// The localized name of the option value.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The effective price of this option value.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        #endregion
    }
}
