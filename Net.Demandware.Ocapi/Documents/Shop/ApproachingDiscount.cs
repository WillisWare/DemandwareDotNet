using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid discount types.
    /// </summary>
    public enum ApproachingDiscountType
    {
        /// <summary>
        /// Indicates an order discount type.
        /// </summary>
        [EnumMember(Value = "order")]
        Order,

        /// <summary>
        /// Indicates a shipping discount type.
        /// </summary>
        [EnumMember(Value = "shipping")]
        Shipping
    }

    /// <summary>
    /// Document representing a note to an object.
    /// </summary>
    public sealed class ApproachingDiscount
    {
        #region Properties

        /// <summary>
        /// The total amount needed to receive the discount.
        /// </summary>
        [JsonProperty(PropertyName = "condition_threshold")]
        public decimal ConditionThreshold { get; set; }

        /// <summary>
        /// The discount the customer can receive if eligible.
        /// </summary>
        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; set; }

        /// <summary>
        /// The amount the customer basket contributes towards the purchase condition.
        /// </summary>
        [JsonProperty(PropertyName = "merchandise_total")]
        public decimal MerchandiseTotal { get; set; }

        /// <summary>
        /// The link to details of the promotion associated with this discount.
        /// </summary>
        [JsonProperty(PropertyName = "promotion_link")]
        public PromotionLink PromotionLink { get; set; }

        /// <summary>
        /// The unique id of the shipment the discount relates to.
        /// </summary>
        [JsonProperty(PropertyName = "shipment_id")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The shipping methods the promotion relates to.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_methods")]
        public IEnumerable<ShippingMethod> ShippingMethods { get; set; } = new List<ShippingMethod>();

        /// <summary>
        /// The type of the approaching discount ("order" or "shipping").
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = "type")]
        public ApproachingDiscountType Type { get; set; }

        #endregion
    }
}
