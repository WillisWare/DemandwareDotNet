using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a gift certificate item.
    /// </summary>
    public sealed class GiftCertificateItem : BaseClass
    {
        #region Properties

        /// <summary>
        /// The certificate item amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount", Required = Required.DisallowNull)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Id used to identify this item.
        /// </summary>
        [JsonProperty(PropertyName = "gift_certificate_item_id")]
        public override string Id { get; set; }

        /// <summary>
        /// The certificate's message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        [StringLength(250)]
        public string Message { get; set; }

        /// <summary>
        /// The recipient's email.
        /// </summary>
        [JsonProperty(PropertyName = "recipient_email", Required = Required.DisallowNull)]
        [MinLength(1)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// The recipient's name.
        /// </summary>
        [JsonProperty(PropertyName = "recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// The sender's name.
        /// </summary>
        [JsonProperty(PropertyName = "sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// The shipment id.
        /// </summary>
        [JsonProperty(PropertyName = "shipment_id")]
        public string ShipmentId { get; set; }

        #endregion
    }
}
