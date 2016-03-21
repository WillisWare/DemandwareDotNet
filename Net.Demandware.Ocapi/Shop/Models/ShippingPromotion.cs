using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a shipping promotion.
    /// </summary>
    public sealed class ShippingPromotion : BasePromotion
    {
        #region Properties

        /// <summary>
        /// The localized promotion name.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_name")]
        public string Name { get; set; }

        #endregion
    }
}
