using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the shipping status of a shipment.
    /// </summary>
    public enum ShipmentShippingStatus
    {
        /// <summary>
        /// Indicates a not shipped status.
        /// </summary>
        [EnumMember(Value = "not_shipped")]
        NotShipped,

        /// <summary>
        /// Indicates a shipped status.
        /// </summary>
        [EnumMember(Value = "shipped")]
        Shipped
    }

    /// <summary>
    /// Represents a shipment.
    /// </summary>
    public sealed class Shipment : BaseClass
    {
        #region Properties

        /// <summary>
        /// The products tax after discounts applying in purchase currency. Adjusted merchandize prices represent the sum of product prices before services such as shipping have been added, but after adjustment from promotions have been added.
        /// </summary>
        /// <remarks>Note that order level adjustments are considered if Discount Taxation preference is set to "Tax Products and Shipping Only Based on Adjusted Price".</remarks>
        [JsonProperty(PropertyName = "adjusted_merchandize_total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdjustedMerchandiseTax { get; set; }

        /// <summary>
        /// The tax of all shipping line items of the line item container after shipping adjustments have been applied.
        /// </summary>
        [JsonProperty(PropertyName = "adjusted_shipping_total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdjustedShippingTax { get; set; }

        /// <summary>
        /// The gift message.
        /// </summary>
        [JsonProperty(PropertyName = "gift_message")]
        public string GiftMessage { get; set; }

        /// <summary>
        /// The order specific id to identify the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "shipment_id")]
        public override string Id { get; set; }

        /// <summary>
        /// A flag indicating whether the shipment is a gift.
        /// </summary>
        [JsonProperty(PropertyName = "gift")]
        public bool IsGift { get; set; }

        /// <summary>
        /// The products total tax in purchase currency. Merchandize total prices represent the sum of product prices before services such as shipping or adjustment from promotions have been added.
        /// </summary>
        [JsonProperty(PropertyName = "merchandize_total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MerchandiseTax { get; set; }

        /// <summary>
        /// Returns the shipment number for this shipment. This number is automatically generated.
        /// </summary>
        [JsonProperty(PropertyName = "shipment_no")]
        public string Number { get; set; }

        /// <summary>
        /// The total price of all product items after all product discounts. Depending on taxation policy the returned price is net or gross.
        /// </summary>
        [JsonProperty(PropertyName = "product_sub_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ProductSubtotal { get; set; }

        /// <summary>
        /// The total price of all product items after all product and order discounts. Depending on taxation policy the returned price is net or gross.
        /// </summary>
        [JsonProperty(PropertyName = "product_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ProductTotal { get; set; }

        /// <summary>
        /// The shipping address.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_address")]
        public OrderAddress ShippingAddress { get; set; }

        /// <summary>
        /// The shipping method.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_method")]
        public ShippingMethod ShippingMethod { get; set; }

        /// <summary>
        /// The tax of all shipping line items of the line item container before shipping adjustments have been applied.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ShippingTax { get; set; }

        /// <summary>
        /// The total shipping price of the shipment after all shipping discounts. Excludes tax if taxation policy is net. Includes tax if taxation policy is gross.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ShippingTotal { get; set; }

        /// <summary>
        /// The shipping status of the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_status")]
        public ShipmentShippingStatus ShippingStatus { get; set; }

        /// <summary>
        /// The total tax amount of the shipment.
        /// </summary>
        /// <remarks>Note that order level adjustments are considered if Discount Taxation preference is set to "Tax Products and Shipping Only Based on Adjusted Price".</remarks>
        [JsonProperty(PropertyName = "tax_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The total price of the shipment, including products, shipping and tax.
        /// </summary>
        /// <remarks>Note that order level adjustments are not considered.</remarks>
        [JsonProperty(PropertyName = "shipment_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        #endregion
    }
}
