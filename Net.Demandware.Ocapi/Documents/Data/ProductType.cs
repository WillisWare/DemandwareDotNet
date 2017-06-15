using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a product type.
    /// </summary>
    public sealed class ProductType : BaseProductType
    {
        #region Properties

        /// <summary>
        /// A flag indicating whether the product is bundled.
        /// </summary>
        [JsonProperty(PropertyName = "bundled")]
        public bool IsBundled { get; set; }

        /// <summary>
        /// A flag indicating whether the product is part of product set.
        /// </summary>
        [JsonProperty(PropertyName = "part_of_product_set")]
        public bool IsPartOfProductSet { get; set; }

        /// <summary>
        /// A flag indicating whether the product is part of retail set.
        /// </summary>
        [JsonProperty(PropertyName = "part_of_retail_set")]
        public bool IsPartOfRetailSet { get; set; }

        /// <summary>
        /// A flag indicating whether the product is a retail set.
        /// </summary>
        [JsonProperty(PropertyName = "retail_set")]
        public bool IsRetailSet { get; set; }

        #endregion
    }
}
