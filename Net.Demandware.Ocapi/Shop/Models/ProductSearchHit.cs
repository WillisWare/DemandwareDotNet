using System.Collections.Generic;
using Net.Demandware.Ocapi.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a product search hit.
    /// </summary>
    public sealed class ProductSearchHit : SimpleLink
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
        public string Id { get; set; }

        /// <summary>
        /// The first image of the product hit for the configured viewtype.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        /// <summary>
        /// A flag indicating whether the product is orderable.
        /// </summary>
        [JsonProperty(PropertyName = "orderable")]
        public bool IsOrderable { get; set; }

        /// <summary>
        /// The maximum sales of related child products in case of complex products like master or set.
        /// </summary>
        [JsonProperty(PropertyName = "price_maximum")]
        public decimal MaximumPrice { get; set; }

        /// <summary>
        /// The localized name of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_name")]
        public string Name { get; set; }

        /// <summary>
        /// The sales price of the product.
        /// </summary>
        /// <remarks>In case of complex products like master or set this is the minimum price of related child products.</remarks>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The prices map with price book ids and their values.
        /// </summary>
        [JsonProperty(PropertyName = "prices")]
        public IDictionary<string, decimal> Prices { get; set; }

        /// <summary>
        /// The type information for the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_type")]
        public ProductType Type { get; set; }

        /// <summary>
        /// The array of represented variation attributes (for the master product only). This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "variation_attributes")]
        public IEnumerable<VariationAttribute> VariationAttributes { get; set; }

        #endregion
    }
}
