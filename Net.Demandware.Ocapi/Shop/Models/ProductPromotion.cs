using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product promotion.
    /// </summary>
    public sealed class ProductPromotion : BasePromotion
    {
        #region Properties

        /// <summary>
        /// The promotional price for this product.
        /// </summary>
        [JsonProperty(PropertyName = "promotional_price")]
        public decimal Price { get; set; }

        #endregion
    }
}
