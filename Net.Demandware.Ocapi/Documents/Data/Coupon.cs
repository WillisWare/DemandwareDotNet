using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid coupon types.
    /// </summary>
    public enum CouponType
    {
        [EnumMember(Value = "single_code")]
        SingleCode,

        [EnumMember(Value = "multiple_codes")]
        MultipleCodes,

        [EnumMember(Value = "system_codes")]
        SystemCodes
    }

    /// <summary>
    /// Represents a coupon.
    /// </summary>
    public sealed class Coupon : BaseClass
    {
        #region Properties

        /// <summary>
        /// The description of the coupon.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// The number of coupon codes attached to the coupon that have been issued (request search only).
        /// </summary>
        [JsonProperty(PropertyName = "exported_code_count")]
        public int ExportedCodeCount { get; set; }

        /// <summary>
        /// The id of the coupon.
        /// </summary>
        [JsonProperty(PropertyName = "coupon_id", Required = Required.DisallowNull)]
        [StringLength(256, MinimumLength = 1)]
        public override string Id { get; set; }

        /// <summary>
        /// A flag indicating whether the coupon is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// A link to the coupon.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The number of times the coupon has been redeemed (request search only).
        /// </summary>
        [JsonProperty(PropertyName = "redemption_count")]
        public int RedemptionCount { get; set; }

        /// <summary>
        /// The redemption limit per coupon code.
        /// </summary>
        [JsonProperty(PropertyName = "redemption_limits")]
        public RedemptionLimits RedemptionLimits { get; set; }

        /// <summary>
        /// Single coupon code, only valid for Single Code type.
        /// </summary>
        [JsonProperty(PropertyName = "single_code", Required = Required.DisallowNull)]
        [StringLength(256, MinimumLength = 1)]
        public string SingleCode { get; set; }

        /// <summary>
        /// The configuration of system coupon codes, including pre-fix and number of codes.
        /// </summary>
        [JsonProperty(PropertyName = "system_codes_config")]
        public CouponSystemCodeConfig SystemCodesConfiguration { get; set; }

        /// <summary>
        /// The total number of coupon codes associated with this coupon.
        /// </summary>
        [JsonProperty(PropertyName = "total_codes_count")]
        public int TotalCodesCount { get; set; }

        /// <summary>
        /// The type of the coupon code.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public new CouponType Type { get; set; }

        #endregion
    }
}
