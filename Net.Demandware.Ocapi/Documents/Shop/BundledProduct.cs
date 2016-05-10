using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a bundled product within a product bundle.
    /// </summary>
    public sealed class BundledProduct
    {
        #region Properties

        /// <summary>
        /// The product being bundled.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public Product Product { get; set; }

        /// <summary>
        /// For the product being bundled, the quantity added to the bundle.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }

        #endregion
    }
}
