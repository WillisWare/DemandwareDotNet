using Net.Demandware.Ocapi.DataTypes;
using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a link to a product list.
    /// </summary>
    public sealed class ProductListLink : SimpleLink
    {
        #region Properties

        /// <summary>
        /// The description of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// A flag indicating whether the owner made this product list available for access by other customers.
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// The name of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public Localized<string> Title { get; set; }

        /// <summary>
        /// The type of the product list.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ProductListType Type { get; set; }

        #endregion
    }
}
