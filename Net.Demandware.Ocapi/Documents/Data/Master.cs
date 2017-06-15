using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a variation master.
    /// </summary>
    public sealed class Master
    {
        #region Properties

        /// <summary>
        /// The URL addressing the master product.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        [JsonRequired]
        public string Link { get; set; }

        /// <summary>
        /// The id (SKU) of the master product.
        /// </summary>
        [JsonProperty(PropertyName = "master_id")]
        [JsonRequired]
        [StringLength(100, MinimumLength = 1)]
        public string Id { get; set; }

        /// <summary>
        /// A flag indicating whether at least one of the variants is orderable.
        /// </summary>
        [JsonProperty(PropertyName = "orderable")]
        public bool IsOrderable { get; set; }

        /// <summary>
        /// The maximum sales of related variants.
        /// </summary>
        [JsonProperty(PropertyName = "price_max")]
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// The minimum sales price of the related variants.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        #endregion
    }
}
