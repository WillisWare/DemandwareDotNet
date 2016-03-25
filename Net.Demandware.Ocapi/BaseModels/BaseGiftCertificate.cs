using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Enumerates the valid statuses for the gift certificate.
    /// </summary>
    public enum GiftCertificateStatus
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "issued")]
        Issued,

        [EnumMember(Value = "partially_redeemed")]
        PartiallyRedeemed,

        [EnumMember(Value = "redeemed")]
        Redeemed
    }

    /// <summary>
    /// Represents the basic structure of a gift certificate.
    /// </summary>
    public abstract class BaseGiftCertificate
    {
        #region Properties

        /// <summary>
        /// The gift certificate description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Is the gift certificate is enabled?
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The masked gift certificate code.
        /// </summary>
        [JsonProperty(PropertyName = "masked_gift_certificate_code")]
        public string MaskedCode { get; set; }

        /// <summary>
        /// The merchant ID.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// The message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The recipient email.
        /// </summary>
        [JsonProperty(PropertyName = "recipient_email")]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// The recipient name.
        /// </summary>
        [JsonProperty(PropertyName = "recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// The sender name.
        /// </summary>
        [JsonProperty(PropertyName = "sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// The gift certificate status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public GiftCertificateStatus Status { get; set; }

        #endregion
    }
}
