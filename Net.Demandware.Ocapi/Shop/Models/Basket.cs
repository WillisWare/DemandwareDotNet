using System.Collections.Generic;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Enumerates valid taxation methods.
    /// </summary>
    public enum Taxation
    {
        [EnumMember(Value = "gross")]
        Gross,

        [EnumMember(Value = "net")]
        Net
    }

    /// <summary>
    /// Represents a basket.
    /// </summary>
    /// <remarks>
    /// The following flashes are used to indicate the in-validity of a basket:
    /// <list type="table">
    /// <item><term>InvalidProductItem</term><description>a product item (or bundled product item) refers to a product which no longer exists, is offline, or the product is no longer assigned to a site catalog.</description></item>
    /// <item><term>InvalidOptionItem</term><description>indicates that an option item refers to an option id or option value which no longer exists.</description></item>
    /// <item><term>OptionItemWithoutPrice</term><description>indicates an option item without a price.</description></item>
    /// <item><term>InvalidCouponCode</term><description>indicates a coupon item became invalid, for example because its redemption limit is reached.</description></item>
    /// <item><term>ProductItemNotAvailable</term><description>indicates too little available inventory to support the item quantity.</description></item>
    /// <item><term>ProductItemWithoutPrice</term><description>indicates that the item has no price.</description></item>
    /// <item><term>CustomerEmailRequired</term><description>indicates the need to specify a customer email.</description></item>
    /// <item><term>ShippingAddressRequired</term><description>indicates the need to specify a shipping address.</description></item>
    /// <item><term>BillingAddressRequired</term><description>indicates the need to specify a billing address.</description></item>
    /// <item><term>ShippingMethodRequired</term><description>indicates the need to specify a shipping method.</description></item>
    /// <item><term>ShippingMethodNotApplicable</term><description>indicates that the currently specified shipping method is not applicable for the given addresses or product items.</description></item>
    /// <item><term>PaymentMethodRequired</term><description>indicates the need to specify a payment method.</description></item>
    /// <item><term>PaymentMethodNotApplicable</term><description>the currently specified payment method is not applicable for the given addresses or product items.</description></item>
    /// <item><term>OrderTotalNotSet</term><description>the basket calculation could not be completed for some reason.</description></item>
    /// <item><term>ProductItemAdjustedPriceLessThanZero</term><description>a price adjustment reduces an item price to a value below zero and should be corrected.</description></item>
    /// </list>
    /// </remarks>
    public sealed class Basket : BaseClass
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
        /// The unique identifier for the basket.
        /// </summary>
        [JsonProperty(PropertyName = "basket_id")]
        public override string Id { get; set; }

        /// <summary>
        /// Is the basket is created by an agent?
        /// </summary>
        [JsonProperty(PropertyName = "agent_basket")]
        public bool IsAgentBasket { get; set; }

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
        public Taxation Taxation { get; set; }

        #endregion
    }
}
