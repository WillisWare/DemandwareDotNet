using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid levels for the proce adjustment.
    /// </summary>
    public enum PriceAdjustmentLevel
    {
        [EnumMember(Value = "product")]
        Product,

        [EnumMember(Value = "shipping")]
        Shipping,

        [EnumMember(Value = "order")]
        Order
    }

    /// <summary>
    /// Represents a price adjustment request.
    /// </summary>
    /// <remarks>
    /// Use the level and item_id properties to specify where you want the price adjustment to be added:
    /// <list type="bullet">
    /// <item>If you specify order as the level, you do not have to specify an item_id.This indicates that the price adjustment should be added directly to basket.</item>
    /// <item>If you specify product as the level, the item_id that you specify is the item_id of the product item. This indicates that the price adjustment should be added to the product item.</item>
    /// <item>If you specify shipping as the level, item_id that you specify is the item_id of the shipping item. This indicates that the price adjustment is added to the shipping item.</item>
    /// </list>
    /// You can use the item_text and reason_code properties to describe the price adjustment.
    /// The promotion_id property is optional.If you do not specify an id, one is automatically assigned (in the format 'dw.manual[n]', where[n] is 1, 2, 3...). If you specify an id, make sure that it is not already used for a price adjustment in the basket or for a promotion in the promotion engine.
    /// You need to specify the value of the price adjustment by defining a discount from which the price adjustment is calculated.The discount definition consists of a type and a value.
    /// <para>
    /// The type amount describes a (unit) price discount, and its corresponding value (positive) defines the amount each unit is to be reduced. For example, for a $10 discount:
    /// <example>{ "discount" : {"type" : "amount", "value" : 10.00 }, ... }</example>
    /// </para>
    /// <para>
    /// The type percentage describes a percentage discount, and its corresponding value (positive) defines the percentage reduction. For example, for a 5% discount:
    /// <example>{ "discount" : {"type" : "percentage", "value" : 5 }, ... }</example>
    /// </para>
    /// <para>
    /// The type fixed_price describes a fixed price discount, and its corresponding value (positive) defines the resulting fixed price for the item. Only one fixed_price discount can be set for each item. For example, to fix a $15 price for the item:
    /// <example>{ "discount" : {"type" : "fixed_price", "value" : 15.00 }, ... }</example>
    /// </para>
    /// The type fixed_price is not applicable at the order level.
    /// </remarks>
    public sealed class PriceAdjustmentRequest
    {
        #region Properties

        /// <summary>
        /// A discount that you can specify instead of a price. When defining a discount, you must specify a type and a value.
        /// </summary>
        [JsonProperty(PropertyName = "discount")]
        public DiscountRequest Discount { get; set; }

        /// <summary>
        /// The item to which the price adjustment should be added, depending on the specified level.
        /// </summary>
        /// <remarks>If the level is 'order', you need not specify an item id. If 'shipping', specify the uuid of the shipping item. If 'product', specify the uuid of the product item.</remarks>
        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// The text describing the item in more detail.
        /// </summary>
        [JsonProperty(PropertyName = "item_text")]
        public string ItemText { get; set; }

        /// <summary>
        /// The level at which the adjustment is applied.
        /// </summary>
        /// <remarks>When a product or shipping level is specified, you must also specify the item id.</remarks>
        [JsonProperty(PropertyName = "level", Required = Required.DisallowNull)]
        public PriceAdjustmentLevel Level { get; set; }

        /// <summary>
        /// The id of the related promotion.
        /// </summary>
        /// <remarks>Custom price adjustments can be assigned any promotion id so long it is not used by a price adjustment belonging to the same item and is not used by promotion defined in the promotion engine. If not specified, a promotion id is generated.</remarks>
        [JsonProperty(PropertyName = "promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// The reason why this price adjustment was made.
        /// </summary>
        [JsonProperty(PropertyName = "reason_code")]
        public string ReasonCode { get; set; }

        #endregion
    }
}
