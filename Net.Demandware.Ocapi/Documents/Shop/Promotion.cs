using System;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a promotion.
    /// </summary>
    public sealed class Promotion : BaseClass
    {
        #region Properties

        /// <summary>
        /// The localized call-out message of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "callout_msg")]
        public string CalloutMessage { get; set; }

        /// <summary>
        /// The currency that a promotion can be applied to.
        /// </summary>
        /// <remarks>A null value means that the promotion applies to all allowed currencies.</remarks>
        [JsonProperty(PropertyName = "currency", NullValueHandling = NullValueHandling.Include)]
        public string Currency { get; set; }

        /// <summary>
        /// The localized detailed description of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        /// <summary>
        /// An optional product search link.
        /// </summary>
        /// <remarks>Product promotions that are marked searchable provide a product search link with the promotion id as refinement.</remarks>
        [JsonProperty(PropertyName = "discounted_products_link")]
        public string DiscountedProductsLink { get; set; }

        /// <summary>
        /// The end date of the promotion.
        /// </summary>
        /// <remarks>This property follows the ISO8601 date time format: yyyy-MM-dd'T'HH:mmZ . The time zone of the date time is always UTC.</remarks>>
        [JsonProperty(PropertyName = "end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The URL to the promotion image.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// The localized name of the promotion.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The start date of the promotion.
        /// </summary>
        /// <remarks>This property follows the ISO8601 date time format: yyyy-MM-dd'T'HH:mmZ. The time zone of the date time is always UTC.</remarks>
        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }

        #endregion
    }
}
