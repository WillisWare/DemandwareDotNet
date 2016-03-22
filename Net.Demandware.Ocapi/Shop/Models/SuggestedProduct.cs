using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a suggested product.
    /// </summary>
    public sealed class SuggestedProduct : BaseSuggestedItem
    {
        #region Properties

        /// <summary>
        /// The ISO 4217 mnemonic code of the currency.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The id (SKU) of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_id")]
        public override string Id { get; set; }

        /// <summary>
        /// The first image of the product hit for the configured viewtype.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        /// <summary>
        /// The sales price of the product.
        /// </summary>
        /// <remarks>In the case of complex products like a master or a set, this is the minimum price of related child products.</remarks>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        #endregion
    }
}
