using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a coupon code configuration.
    /// </summary>
    public sealed class CouponSystemCodeConfig
    {
        #region Properties

        /// <summary>
        /// The code prefix for system-generated coupon codes.
        /// </summary>
        [JsonProperty(PropertyName = "code_prefix")]
        public string CodePrefix { get; set; }

        /// <summary>
        /// The number of system coupon codes that can be issued.
        /// </summary>
        [JsonProperty(PropertyName = "number_of_codes")]
        public int Count { get; set; }

        #endregion
    }
}
