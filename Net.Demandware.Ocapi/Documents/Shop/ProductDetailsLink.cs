using Net.Demandware.Ocapi.DataTypes;
using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a link to the resource for product details.
    /// </summary>
    public sealed class ProductDetailsLink : SimpleLink
    {
        #region Properties

        /// <summary>
        /// The description of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_description")]
        public Localized<string> ProductDescription { get; set; }

        /// <summary>
        /// The id of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_id", Required = Required.DisallowNull)]
        public string ProductId { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_name")]
        public Localized<string> ProductName { get; set; }

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public Localized<string> Title { get; set; }

        #endregion
    }
}
