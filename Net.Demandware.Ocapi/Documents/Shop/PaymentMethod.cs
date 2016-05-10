using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a payment method.
    /// </summary>
    public sealed class PaymentMethod
    {
        #region Properties

        /// <summary>
        /// The sorted array of payment cards (included only when the system payment method is CREDIT_CARD).
        /// </summary>
        [JsonProperty(PropertyName = "cards")]
        public IEnumerable<PaymentCardSpec> Cards { get; set; }

        /// <summary>
        /// The localized description of the payment method or card.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The id of the payment method or card.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.DisallowNull)]
        [StringLength(256)]
        public string Id { get; set; }

        /// <summary>
        /// The URL to the image that represents the payment method or card.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// The localized name of the payment method or card.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        #endregion
    }
}
