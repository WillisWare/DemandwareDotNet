using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a variation group.
    /// </summary>
    public class VariationGroup : SimpleLink
    {
        #region Properties

        /// <summary>
        /// A flag indicating whether the variation group is orderable.
        /// </summary>
        [JsonProperty(PropertyName = "orderable")]
        public bool IsOrderable { get; set; }

        /// <summary>
        /// The sales price of the variation group.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The id (SKU) of the variant.
        /// </summary>
        [JsonProperty(PropertyName = "product_id", Required = Required.Always)]
        [StringLength(100, MinimumLength = 1)]
        public string ProductId { get; set; }

        /// <summary>
        /// The actual variation attribute id - value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "variation_values")]
        public IDictionary<string, string> Values { get; set; }

        #endregion
    }
}
