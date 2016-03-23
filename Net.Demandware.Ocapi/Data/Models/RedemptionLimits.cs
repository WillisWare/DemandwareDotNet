using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a coupon.
    /// </summary>
    public sealed class RedemptionLimits
    {
        #region Properties

        /// <summary>
        /// The redemption limit per customer.
        /// </summary>
        [JsonProperty(PropertyName = "limit_per_code", NullValueHandling = NullValueHandling.Include)]
        public int LimitPerCode { get; set; }

        /// <summary>
        /// The redemption limit per customer.
        /// </summary>
        [JsonProperty(PropertyName = "limit_per_customer", NullValueHandling = NullValueHandling.Include)]
        public int LimitPerCustomer { get; set; }

        /// <summary>
        /// The redemption limit per time frame.
        /// </summary>
        [JsonProperty(PropertyName = "limit_per_time_frame")]
        public RedemptionLimitPerPeriod LimitPerTimeFrame { get; set; }

        #endregion
    }
}
