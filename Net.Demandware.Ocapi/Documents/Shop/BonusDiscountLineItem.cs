using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Document representing a bonus discount line item.
    /// </summary>
    public sealed class BonusDiscountLineItem : BaseClass
    {
        #region Properties

        /// <summary>
        /// The list of links to the bonus products the customer can choose from.
        /// </summary>
        [JsonProperty(PropertyName = "bonus_products")]
        public IEnumerable<ProductDetailsLink> BonusProducts { get; set; } = new List<ProductDetailsLink>();

        /// <summary>
        /// The coupon code that triggered the promotion, if applicable.
        /// </summary>
        [JsonProperty(PropertyName = "coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// The maximum number of bonus items the user can select for this promotion.
        /// </summary>
        [JsonProperty(PropertyName = "max_bonus_items")]
        public int MaxBonusItems { get; set; }

        /// <summary>
        /// The ID of the promotion which triggered the creation of the line item.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_id")]
        public string PromotionId { get; set; }

        #endregion
    }
}
