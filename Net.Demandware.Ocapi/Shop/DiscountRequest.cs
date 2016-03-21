using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Enumerates the valid types for the request.
    /// </summary>
    public enum DiscountRequestType
    {
        [EnumMember(Value = "percentage")]
        Percentage,

        [EnumMember(Value = "fixed_price")]
        FixedPrice,

        [EnumMember(Value = "amount")]
        Amount
    }

    /// <summary>
    /// Represents a discount to be applied to a custom price adjustment.
    /// <para>
    /// The type amount describes a (unit) price discount, and its corresponding value (positive) defines the amount each unit is to be reduced. For example, for a $10 discount:
    /// <example>{ "discount" : {"type" : "amount", "value" : 10.00 }, ... }</example>
    /// </para>
    /// <para>
    /// The type percentage describes a percentage discount, and its corresponding value (positive) defines the percentage reduction. For example, for a 5% discount:
    /// <example>{ "discount" : {"type" : "percentage", "value" : 5 }, ... }</example>
    /// </para>
    /// <para>
    /// The type fixed_price describes a fixed price discount, and its corresponding value (positive) defines the resulting fixed price for the item. Only one fixed_price discount can be set for each item. For example, to set a fixed price of $15 for the item:
    /// <example>{ "discount" : {"type" : "fixed_price", "value" : 15.00 }, ... }</example>
    /// </para>
    /// The type fixed_price is not supported at the order level.
    /// </summary>
    /// <remarks>The properties type and value are mandatory.</remarks>
    public sealed class DiscountRequest
    {
        #region Properties

        /// <summary>
        /// The type of discount.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.DisallowNull)]
        public DiscountRequestType Type { get; set; }

        /// <summary>
        /// The amount of the discount.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.DisallowNull)]
        public decimal Value { get; set; }

        #endregion
    }
}
