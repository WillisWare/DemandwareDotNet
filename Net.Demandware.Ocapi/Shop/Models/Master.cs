using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a variation master.
    /// </summary>
    public sealed class Master : BaseClass
    {
        #region Properties

        /// <summary>
        /// The id (SKU) of the master product.
        /// </summary>
        [JsonProperty(PropertyName = "master_id")]
        public override string Id { get; set; }

        /// <summary>
        /// A flag indicating whether at least one of the variants is orderable.
        /// </summary>
        [JsonProperty(PropertyName = "orderable")]
        public bool IsOrderable { get; set; }

        /// <summary>
        /// The URL addressing the master product.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The maximum sales of related variants.
        /// </summary>
        [JsonProperty(PropertyName = "price_max")]
        public decimal MaximumPrice { get; set; }

        /// <summary>
        /// The minimum sales price of the related variants.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal MinimumPrice { get; set; }

        #endregion
    }
}
