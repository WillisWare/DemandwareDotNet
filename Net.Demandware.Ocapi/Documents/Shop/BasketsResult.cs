using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a result containing an array of baskets.
    /// </summary>
    public sealed class BasketsResult
    {
        #region Properties

        /// <summary>
        /// The list of baskets for a customer.
        /// </summary>
        [JsonProperty(PropertyName = "baskets")]
        public IEnumerable<Basket> Baskets { get; set; }

        /// <summary>
        /// The total number of baskets.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        #endregion
    }
}
