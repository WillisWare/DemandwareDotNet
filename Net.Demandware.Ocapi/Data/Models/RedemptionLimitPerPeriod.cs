using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a coupon redemption limit.
    /// </summary>
    public sealed class RedemptionLimitPerPeriod
    {
        #region Properties

        /// <summary>
        /// The limit on the number of times a coupon can be redeemed for a specified redemption time period.
        /// </summary>
        [JsonProperty(PropertyName = "limit", NullValueHandling = NullValueHandling.Include)]
        public int Limit { get; set; }

        /// <summary>
        /// The redemption time period.
        /// </summary>
        [JsonProperty(PropertyName = "redemption_time_frame", NullValueHandling = NullValueHandling.Include)]
        [Range(0, 999)]
        public int TimeFrame { get; set; }

        #endregion
    }
}
