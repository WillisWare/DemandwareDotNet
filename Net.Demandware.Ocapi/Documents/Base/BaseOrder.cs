using System.Collections.Generic;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Documents.Shop;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Base
{
    /// <summary>
    /// Enumerates the valid sales channels for the order.
    /// </summary>
    public enum OrderChannelType
    {
        /// <summary>
        /// Indicates a storefront channel.
        /// </summary>
        [EnumMember(Value = "storefront")]
        Storefront,

        /// <summary>
        /// Indicates a call center channel.
        /// </summary>
        [EnumMember(Value = "callcenter")]
        CallCenter,

        /// <summary>
        /// Indicates a customer service center channel.
        /// </summary>
        [EnumMember(Value = "customerservicecenter")]
        CustomerServiceCenter,

        /// <summary>
        /// Indicates a DSS channel.
        /// </summary>
        [EnumMember(Value = "dss")]
        Dss,

        /// <summary>
        /// Indicates a Facebook Ads channel.
        /// </summary>
        [EnumMember(Value = "facebookads")]
        FacebookAds,

        /// <summary>
        /// Indicates a marketplace channel.
        /// </summary>
        [EnumMember(Value = "marketplace")]
        Marketplace,

        /// <summary>
        /// Indicates an online reservation channel.
        /// </summary>
        [EnumMember(Value = "onlinereservation")]
        OnlineReservation,

        /// <summary>
        /// Indicates a Pinterest channel.
        /// </summary>
        [EnumMember(Value = "pinterest")]
        Pinterest,

        /// <summary>
        /// Indicates a store channel.
        /// </summary>
        [EnumMember(Value = "store")]
        Store,

        /// <summary>
        /// Indicates a subscriptions channel.
        /// </summary>
        [EnumMember(Value = "subscriptions")]
        Subscriptions,

        /// <summary>
        /// Indicates a Twitter channel.
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter
    }

    /// <summary>
    /// Enumerates the valid confirmation statuses for the order.
    /// </summary>
    public enum OrderConfirmationStatus
    {
        /// <summary>
        /// Indicates a not confirmed status.
        /// </summary>
        [EnumMember(Value = "not_confirmed")]
        NotConfirmed,

        /// <summary>
        /// Indicates a confirmed status.
        /// </summary>
        [EnumMember(Value = "confirmed")]
        Confirmed
    }

    /// <summary>
    /// Enumerates the valid export statuses for the order.
    /// </summary>
    public enum OrderExportStatus
    {
        /// <summary>
        /// Indicates a not exported status.
        /// </summary>
        [EnumMember(Value = "not_exported")]
        NotExported,

        /// <summary>
        /// Indicates an exported status.
        /// </summary>
        [EnumMember(Value = "exported")]
        Exported,

        /// <summary>
        /// Indicates a ready-to-export status.
        /// </summary>
        [EnumMember(Value = "ready")]
        Ready,

        /// <summary>
        /// Indicates a failed status.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }

    /// <summary>
    /// Enumerates the valid payment statuses for the order.
    /// </summary>
    public enum OrderPaymentStatus
    {
        /// <summary>
        /// Indicates a not paid status.
        /// </summary>
        [EnumMember(Value = "not_paid")]
        NotPaid,

        /// <summary>
        /// Indicates a partly paid status.
        /// </summary>
        [EnumMember(Value = "part_paid")]
        PartPaid,

        /// <summary>
        /// Indicates a paid status.
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid
    }

    /// <summary>
    /// Enumerates the valid shipping statuses for the order.
    /// </summary>
    public enum OrderShippingStatus
    {
        /// <summary>
        /// Indicates a not shipped status.
        /// </summary>
        [EnumMember(Value = "not_shipped")]
        NotShipped,

        /// <summary>
        /// Indicates a partly shipped status.
        /// </summary>
        [EnumMember(Value = "part_shipped")]
        PartShipped,

        /// <summary>
        /// Indicates a shipped status.
        /// </summary>
        [EnumMember(Value = "shipped")]
        Shipped
    }

    /// <summary>
    /// Enumerates the valid statuses for the order.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Indicates a created status.
        /// </summary>
        [EnumMember(Value = "created")]
        Created,

        /// <summary>
        /// Indicates a new status.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Indicates an open status.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Indicates a completed status.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,

        /// <summary>
        /// Indicates a canceled status.
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Canceled,

        /// <summary>
        /// Indicates a replaced status.
        /// </summary>
        [EnumMember(Value = "replaced")]
        Replaced,

        /// <summary>
        /// Indicates a failed status.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }

    /// <summary>
    /// Enumerates the valid taxation methods for the order.
    /// </summary>
    public enum OrderTaxationType
    {
        /// <summary>
        /// Indicates a gross taxation type.
        /// </summary>
        [EnumMember(Value = "gross")]
        Gross,

        /// <summary>
        /// Indicates a net taxation type.
        /// </summary>
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
        public IEnumerable<CouponItem> CouponItems { get; set; } = new List<CouponItem>();

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
        /// The order's custom attributes.
        /// </summary>
        [JsonExtensionData]
        public new IDictionary<string, object> CustomAttributes { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// The sorted array of gift certificate line items. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "gift_certificate_items")]
        public IEnumerable<GiftCertificateItem> GiftCertificateItems { get; set; } = new List<GiftCertificateItem>();

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
        public IEnumerable<OrderPaymentInstrument> PaymentInstruments { get; set; } = new List<OrderPaymentInstrument>();

        /// <summary>
        /// The array of order level price adjustments. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "order_price_adjustments")]
        public IEnumerable<PriceAdjustment> PriceAdjustments { get; set; } = new List<PriceAdjustment>();

        /// <summary>
        /// The sorted array of product items (up to a maximum of 50 items). This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "product_items")]
        public IEnumerable<ProductItem> ProductItems { get; set; } = new List<ProductItem>();

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
        public IEnumerable<Shipment> Shipments { get; set; } = new List<Shipment>();

        /// <summary>
        /// The sorted array of shipping items. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_items")]
        public IEnumerable<ShippingItem> ShippingItems { get; set; } = new List<ShippingItem>();

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
