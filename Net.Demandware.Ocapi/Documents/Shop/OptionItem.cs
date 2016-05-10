using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents an option item.
    /// </summary>
    public sealed class OptionItem : ProductItem
    {
        #region Properties

        /// <summary>
        /// The id of the option.
        /// </summary>
        [JsonProperty(PropertyName = "option_id", Required = Required.AllowNull)]
        [StringLength(256)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the option value.
        /// </summary>
        [JsonProperty(PropertyName = "option_value_id", Required = Required.AllowNull)]
        [StringLength(256)]
        public string OptionValueId { get; set; }

        #endregion
    }
}
