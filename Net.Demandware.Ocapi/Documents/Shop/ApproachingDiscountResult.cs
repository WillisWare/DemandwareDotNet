using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// A result of a approaching discount request.
    /// </summary>
    public sealed class ApproachingDiscountResult
    {
        #region Properties

        /// <summary>
        /// Lists approaching discounts.
        /// </summary>
        [JsonProperty(PropertyName = "approaching_discounts")]
        public IEnumerable<ApproachingDiscount> ApproachingDiscounts { get; set; }

        #endregion
    }
}
