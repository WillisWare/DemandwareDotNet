using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
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
