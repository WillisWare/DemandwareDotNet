using System;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a price adjustment within a basket or order. Price adjustments can be assigned at the order, product, or shipping level. They can be created by the promotion engine (if the custom flag is set to false) or can be added by custom logic (if the custom flag is set to true). For custom price adjustments created by a user, the manual flag should be set to true; this is always the case for price adjustments created using OCAPI.
    /// <para>A price adjustment created by custom logic can either define a price that defines the absolute price reduction or define a discount from which a price reduction is calculated(amount, percentage, and fixed_price discounts are supported). The applied_discount property describes the discount applied to create the price-adjustment.</para>
    /// </summary>
    public sealed class PriceAdjustment : BaseClass
    {
        #region Properties

        /// <summary>
        /// A price adjustment that provides details of the discount that was applied. This is null for custom price adjustments created without discount details.
        /// </summary>
        [JsonProperty(PropertyName = "applied_discount")]
        public Discount AppliedDiscount { get; set; }

        /// <summary>
        /// The coupon code that triggered the promotion, provided the price adjustment was created as the result of a promotion being triggered by a coupon.
        /// </summary>
        [JsonProperty(PropertyName = "coupon_code")]
        public string CouponCode { get; set; }

        /// <summary>
        /// The user who created the price adjustment.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The creation date.
        /// </summary>
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The price adjustment id (uuid).
        /// </summary>
        [JsonProperty(PropertyName = "price_adjustment_id")]
        public override string Id { get; set; }

        /// <summary>
        /// A flag indicating whether this price adjustment was created by custom logic. This flag is set to true unless the price adjustment was created by the promotion engine.
        /// </summary>
        [JsonProperty(PropertyName = "custom")]
        public bool IsCustom { get; set; }

        /// <summary>
        /// A flag indicating whether this price adjustment was created in a manual process.
        /// </summary>
        /// <remarks>For custom price adjustments created using the shop API, this always returns true. Using the scripting API, however, it is possible to set this to true or false, according to the use case.</remarks>
        [JsonProperty(PropertyName = "manual")]
        public bool IsManual { get; set; }

        /// <summary>
        /// The text describing the item in more detail.
        /// </summary>
        [JsonProperty(PropertyName = "item_text")]
        public string ItemText { get; set; }

        /// <summary>
        /// Returns the value of attribute 'lastModified'.
        /// </summary>
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The adjustment price.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The id of the related promotion. Custom price adjustments can be assigned any promotion id so long it is not used by a price adjustment belonging to the same item and is not used by promotion defined in the promotion engine. If not specified, a promotion id is generated.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// The URL addressing the related promotion.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_link")]
        public string PromotionLink { get; set; }

        /// <summary>
        /// The reason why this price adjustment was made.
        /// </summary>
        [JsonProperty(PropertyName = "reason_code")]
        public string ReasonCode { get; set; }

        #endregion
    }
}
