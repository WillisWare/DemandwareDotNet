using System;
using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public sealed class Order : BaseOrder
    {
        #region Properties

        /// <summary>
        /// The sales channel for the order.
        /// </summary>
        [JsonProperty(PropertyName = "channel_type")]
        public OrderChannelType Channel { get; set; }

        /// <summary>
        /// The confirmation status of the order.
        /// </summary>
        [JsonProperty(PropertyName = "confirmation_status")]
        public OrderConfirmationStatus ConfirmationStatus { get; set; }

        /// <summary>
        /// The name of the user who created the order.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The order creation date.
        /// </summary>
        /// <remarks>
        /// This property follows the ISO8601 date time format: yyyy-MM-dd'T'HH:mmZ.
        /// The time zone of the date time is always UTC.
        /// </remarks>
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The export status of the order.
        /// </summary>
        [JsonProperty(PropertyName = "export_status")]
        public OrderExportStatus ExportStatus { get; set; }

        /// <summary>
        /// The external status of the order.
        /// </summary>
        [JsonProperty(PropertyName = "external_order_status")]
        public string ExternalOrderStatus { get; set; }

        /// <summary>
        /// Ignored. The ID is specified by the Number field.
        /// </summary>
        [JsonIgnore]
        public override string Id { get; set; }

        /// <summary>
        /// The order number of the order.
        /// </summary>
        [JsonProperty(PropertyName = "order_no")]
        public string Number { get; set; }

        /// <summary>
        /// The payment status of the order.
        /// </summary>
        [JsonProperty(PropertyName = "payment_status")]
        public OrderPaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// The shipping status of the order.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_status")]
        public OrderShippingStatus ShippingStatus { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// The order token used to secure the lookup of an order on base of the plain order number.
        /// </summary>
        /// <remarks>The order token contains only URL safe characters.</remarks>
        [JsonProperty(PropertyName = "order_token")]
        public string Token { get; set; }

        #endregion
    }
}
