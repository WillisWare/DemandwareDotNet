using System.Collections.Generic;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Enumerates the valid sales channels for the order.
    /// </summary>
    public enum OrderChannelType
    {
        [EnumMember(Value = "storefront")]
        Storefront,

        [EnumMember(Value = "callcenter")]
        CallCenter,

        [EnumMember(Value = "marketplace")]
        Marketplace,

        [EnumMember(Value = "dss")]
        Dss,

        [EnumMember(Value = "store")]
        Store,

        [EnumMember(Value = "pinterest")]
        Pinterest,

        [EnumMember(Value = "twitter")]
        Twitter
    }

    /// <summary>
    /// Enumerates the valid confirmation statuses for the order.
    /// </summary>
    public enum OrderConfirmationStatus
    {
        [EnumMember(Value = "not_confirmed")]
        NotConfirmed,

        [EnumMember(Value = "confirmed")]
        Confirmed
    }

    /// <summary>
    /// Enumerates the valid export statuses for the order.
    /// </summary>
    public enum OrderExportStatus
    {
        [EnumMember(Value = "not_exported")]
        NotExported,

        [EnumMember(Value = "exported")]
        Exported,

        [EnumMember(Value = "ready")]
        Ready,

        [EnumMember(Value = "failed")]
        Failed
    }

    /// <summary>
    /// Enumerates the valid payment statuses for the order.
    /// </summary>
    public enum OrderPaymentStatus
    {
        [EnumMember(Value = "not_paid")]
        NotPaid,

        [EnumMember(Value = "part_paid")]
        PartPaid,

        [EnumMember(Value = "paid")]
        Paid
    }

    /// <summary>
    /// Enumerates the valid shipping statuses for the order.
    /// </summary>
    public enum OrderShippingStatus
    {
        [EnumMember(Value = "not_shipped")]
        NotShipped,

        [EnumMember(Value = "part_shipped")]
        PartShipped,

        [EnumMember(Value = "shipped")]
        Shipped
    }

    /// <summary>
    /// Enumerates the valid statuses for the order.
    /// </summary>
    public enum OrderStatus
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "new")]
        New,

        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "completed")]
        Completed,

        [EnumMember(Value = "cancelled")]
        Cancelled,

        [EnumMember(Value = "replaced")]
        Replaced,

        [EnumMember(Value = "failed")]
        Failed
    }

    /// <summary>
    /// Enumerates the valid taxation methods for the order.
    /// </summary>
    public enum OrderTaxationType
    {
        [EnumMember(Value = "gross")]
        Gross,

        [EnumMember(Value = "net")]
        Net
    }

    /// <summary>
    /// Represents the basic structure of an order.
    /// </summary>
    public abstract class BaseOrder : BaseClass
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
        /// The billing address.
        /// </summary>
        /// <remarks>This property is part of basket checkout information only.</remarks>
        [JsonProperty(PropertyName = "billing_address")]
        public OrderAddress BillingAddress { get; set; }

        /// <summary>
        /// The sorted array of coupon items. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "coupon_items")]
        public IEnumerable<CouponItem> CouponItems { get; set; }

        /// <summary>
        /// The ISO 4217 mnemonic code of the currency.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer information for logged in customers.
        /// </summary>
        /// <remarks>This property is part of basket checkout information only.</remarks>
        [JsonProperty(PropertyName = "customer_info")]
        public CustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// The sorted array of gift certificate line items. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "gift_certificate_items")]
        public IEnumerable<GiftCertificateItem> GiftCertificateItems { get; set; }

        /// <summary>
        /// The products total tax in purchase currency. Merchandize total prices represent the sum of product prices before services such as shipping or adjustment from promotions have been added.
        /// </summary>
        [JsonProperty(PropertyName = "merchandize_total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MerchandiseTax { get; set; }

        /// <summary>
        /// The notes for the line item container.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public SimpleLink Notes { get; set; }

        /// <summary>
        /// The total price of the order, including products, shipping and tax.
        /// </summary>
        /// <remarks>This property is part of basket checkout information only.</remarks>
        [JsonProperty(PropertyName = "order_total")]
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// The payment instruments list for the order.
        /// </summary>
        [JsonProperty(PropertyName = "payment_instruments")]
        public IEnumerable<OrderPaymentInstrument> PaymentInstruments { get; set; }

        /// <summary>
        /// The array of order level price adjustments. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "order_price_adjustments")]
        public IEnumerable<PriceAdjustment> PriceAdjustments { get; set; }

        /// <summary>
        /// The sorted array of product items (up to a maximum of 50 items). This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "product_items")]
        public IEnumerable<ProductItem> ProductItems { get; set; }

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
        /// The array of shipments.
        /// </summary>
        /// <remarks>This property is part of basket checkout information only.</remarks>
        [JsonProperty(PropertyName = "shipments")]
        public IEnumerable<Shipment> Shipments { get; set; }

        /// <summary>
        /// The sorted array of shipping items. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_items")]
        public IEnumerable<ShippingItem> ShippingItems { get; set; }

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
        /// The total tax amount of the shipment.
        /// </summary>
        /// <remarks>Note that order level adjustments are considered if Discount Taxation preference is set to "Tax Products and Shipping Only Based on Adjusted Price".</remarks>
        [JsonProperty(PropertyName = "tax_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The taxation the line item container is based on.
        /// </summary>
        [JsonProperty(PropertyName = "taxation")]
        public OrderTaxationType Taxation { get; set; }

        #endregion
    }
}
