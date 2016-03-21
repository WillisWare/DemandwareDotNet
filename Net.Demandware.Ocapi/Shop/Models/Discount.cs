using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Enumerates the valid discount types.
    /// </summary>
    public enum DiscountType
    {
        [EnumMember(Value = "percentage")]
        Percentage,

        [EnumMember(Value = "fixed_price")]
        FixedPrice,

        [EnumMember(Value = "amount")]
        Amount,

        [EnumMember(Value = "free")]
        Free,

        [EnumMember(Value = "price_book_price")]
        PriceBookPrice,

        [EnumMember(Value = "bonus")]
        Bonus,

        [EnumMember(Value = "total_fixed_price")]
        TotalFixedPrice,

        [EnumMember(Value = "bonus_choice")]
        BonusChoice,

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
