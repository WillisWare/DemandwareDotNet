using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents the specification for a payment card.
    /// </summary>
    /// <remarks>The information in the specification can be used to verify data entered by a customer before sending to the payment authorization. The configuration can be made in the payment methods section in Business Manager.</remarks>
    public sealed class PaymentCardSpec
    {
        #region Properties

        /// <summary>
        /// The type of the payment card.
        /// </summary>
        [JsonProperty(PropertyName = "card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// The localized description of the payment card.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The URL to the image that represents the payment card.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// A flag indicating whether the card number is verified using the Luhn checksum algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "checksum_verification_enabled")]
        public bool IsChecksumVerificationEnabled { get; set; }

        /// <summary>
        /// The localized name of the payment card.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The sorted list of number lengths (individual lengths as well as length ranges).
        /// </summary>
        [JsonProperty(PropertyName = "number_lengths")]
        public IEnumerable<string> NumberLengths { get; set; }

        /// <summary>
        /// The sorted list of number prefixes (individual prefixes as well as prefix ranges).
        /// </summary>
        [JsonProperty(PropertyName = "number_prefixes")]
        public IEnumerable<string> NumberPrefixes { get; set; }

        /// <summary>
        /// The length of the security code for this card.
        /// </summary>
        [JsonProperty(PropertyName = "security_code_length")]
        public int SecurityCodeLength { get; set; }

        #endregion
    }
}
