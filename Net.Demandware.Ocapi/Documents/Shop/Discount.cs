using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid discount types.
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// Indicates a percentage type.
        /// </summary>
        [EnumMember(Value = "percentage")]
        Percentage,

        /// <summary>
        /// Indicates a fixed price type.
        /// </summary>
        [EnumMember(Value = "fixed_price")]
        FixedPrice,

        /// <summary>
        /// Indicates an amount type.
        /// </summary>
        [EnumMember(Value = "amount")]
        Amount,

        /// <summary>
        /// Indicates a free type.
        /// </summary>
        [EnumMember(Value = "free")]
        Free,

        /// <summary>
        /// Indicates a price type.
        /// </summary>
        [EnumMember(Value = "price_book_price")]
        PriceBookPrice,

        /// <summary>
        /// Indicates a bonus type.
        /// </summary>
        [EnumMember(Value = "bonus")]
        Bonus,

        /// <summary>
        /// Indicates a fixed price type.
        /// </summary>
        [EnumMember(Value = "total_fixed_price")]
        TotalFixedPrice,

        /// <summary>
        /// Indicates a bonus choice type.
        /// </summary>
        [EnumMember(Value = "bonus_choice")]
        BonusChoice,

        /// <summary>
        /// Indicates a percentage off options type.
        /// </summary>
        [EnumMember(Value = "percentage_off_options")]
        PercentageOffOptions
    }

    /// <summary>
    /// Represents a discount that was either optionally applied when creating a custom price adjustment or applied by the promotion engine.
    /// </summary>
    public sealed class Discount
    {
        #region Properties

        /// <summary>
        /// The amount that is used with the amount and fixed price types.
        /// </summary>
        [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The percentage that is used with percentage types.
        /// </summary>
        [JsonProperty(PropertyName = "percentage", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// The price book id that is used with some types.
        /// </summary>
        [JsonProperty(PropertyName = "price_book_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceBookId { get; set; }

        /// <summary>
        /// The type of discount.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.DisallowNull)]
        public DiscountType Type { get; set; }

        #endregion
    }
}
