using System;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Resources.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to baskets.
    /// </summary>
    /// <remarks>
    /// Uses JWT or an OAuth Business Manager user grant as authentication method. This resource replaces the Basket resource in previous versions.
    /// </remarks>
    public sealed class Baskets : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the baskets API for URL-building.
        /// </summary>
        private const string BASE_PATH = "baskets/";

        #endregion

        #region Methods

        /// <summary>
        /// Adds a coupon to an existing basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="couponItem">A CouponItem document instance containing the coupon.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket AddCouponItem(string basketId, CouponItem couponItem)
        {
            if (string.IsNullOrEmpty(basketId))
            {
                throw new ArgumentNullException(nameof(basketId), Properties.Resources.Error_Missing_Basket_ID);
            }

            var couponUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}{basketId}/coupons";

            var couponResponse = ServiceManager.HttpPost(couponUrl, GetWebHeaders(couponUrl, GetOcapiAuthorizationToken()), GetBytes(couponItem));

            var returnValue = JsonConvert.DeserializeObject<Basket>(couponResponse);

            return returnValue;
        }

        /// <summary>
        /// Adds a gift certificate item to an existing basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="giftCertificateItem">A GiftCertificateItem document instance containing the git certificate item.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket AddGiftCertificateItem(string basketId, GiftCertificateItem giftCertificateItem)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a note to an existing basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="note">A Note document instance containing the note.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket AddNote(string basketId, Note note)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a payment instrument to a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="paymentInstrument">A BasketPaymentInstrumentRequest document instance containing the payment instrument.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <remarks>Payment instruments are usually authorized after order creation, for example in a custom hook. The default payment authorization process executes an authorization when a payment instrument is added to an order or updated. See POST /orders/{order_no}/payment_instruments and PATCH /orders/{order_no}/payment_instruments/{payment_instrument_id}</remarks>
        public Basket AddPaymentInstrument(string basketId, BasketPaymentInstrumentRequest paymentInstrument)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a custom manual price adjustment to the basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="priceAdjustment">A PriceAdjustmentRequest document instance containing the price adjustment.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket AddPriceAdjustment(string basketId, PriceAdjustmentRequest priceAdjustment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new item to a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="productItem">A ProductItem document instance containing the product item.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <remarks>
        /// The added item is associated with the specified shipment. If no shipment id is specified, the added item is associated with the default shipment.
        /// <para>
        /// Considered values from the request body are:
        /// <list type="bullet">
        /// <item><term>product_id</term><definition>a valid product id. This is the id of the product to be added to the basket.</definition></item>
        /// <item><term>shipment_id</term><definition>a valid shipment id (optional). This is the id of the shipment in which the product item is created.</definition></item>
        /// <item><term>quantity</term><definition>a number between 0.01 and 999. This is the quantity of the product to order.</definition></item>
        /// <item><term>inventory_id</term><definition>a valid inventory id (optional). This is the id of the inventory from which the item is allocated.</definition></item>
        /// <item><term>option_items/option_value_id</term><definition>
        /// a valid option value id. This is an option value for an option item of an option product.
        /// <para>
        /// This is only possible if the product item is an option product. To set option values, you must specify a collection of option items in the option_items property. These option items must contain option_id and option_value_id. Also, the values you specify must be valid for the option product that this product item represents. Otherwise, the server throws an InvalidProductOptionItemException or an InvalidProductOptionValueItemException.</para>
        /// </definition></item>
        /// <item><term>custom properties in the form c_&lt;CUSTOM_NAME&gt;</term><definition>the custom property must correspond to a custom attribute (&lt;CUSTOM_NAME&gt;) defined for ProductLineItem. The value of this property must be valid for the type of custom attribute defined for ProductLineItem.</definition></item>
        /// </list>
        /// </para>
        /// </remarks>
        public Basket AddProductItem(string basketId, ProductItem productItem)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new basket.
        /// </summary>
        /// <param name="basket">A Basket document instance containing the values for the new basket.</param>
        /// <returns>A Basket document instance containing the new basket values.</returns>
        /// <remarks>
        /// The created basket is initialized with default values. Data provided in the body document will be populated into the created basket. It can be updated with further shop api calls.
        /// <para>
        /// Considered values from the request body are:
        /// <list type="bullet">
        /// <item>customer information: PUT /baskets/{basket_id}/customer</item>
        /// <item>billing address: PUT /baskets/{basket_id}/billing_address</item>
        /// <item>shipments including shipping address and shipping method: POST /baskets/{basket_id}/shipments</item>
        /// <item>product items: POST /baskets/{basket_id}/items</item>
        /// <item>coupon items: POST baskets/{basket_id}/coupons</item>
        /// <item>gift certificate items: POST baskets/{basket_id}/gift_certificates</item>
        /// <item>payment method and card type: POST baskets/{basket_id}/payment_instruments</item>
        /// <item>custom properties: PATCH baskets/{basket_id}</item>
        /// </list>
        /// </para>
        /// Related resource means with which resource you can specify the same data after the basket creation.
        /// Identify the basket using the basketId property, which should be integrated into the path of an update request, for example a POST to /baskets/{basketId}/items. All updates also use the ETag mechanism to control data consistency. That is, the ETag returned in the response header of the current request must be passed as the If-Match parameter in the header of the subsequent request; otherwise, a IfMatchRequiredException fault will result.
        /// <para>
        /// The resource supports JWT or OAuth tokens for authentication:
        /// <list type="bullet">
        /// <item>A customer must provide a JWT, which specifies exactly one customer (it may be guest- or a registered- customer). In this case the resource creates a basket for this customer.</item>
        /// <item>An agent must provide an OAuth token. The agent can use this resource to create a basket for a new created guest customer, and can later update the customer if desired.</item>
        /// </list>
        /// </para>
        /// <para>
        /// The number of baskets which can be created per customer is limited. When a basket is created it is said to be open. It remains open until it is either submitted using a POST to resource /baskets/{basketId}/submit or deleted using a DELETE to resource /baskets/{basketId}. The number of open baskets allowed depends on the authentication method used:
        /// <list type="bullet">
        /// <item>When using JWT each customer can have just one open basket</item>
        /// <item>When using OAuth each customer can have up to 4 open baskets (this is a quota setting which can be updated by support)</item>
        /// </list>
        /// </para>
        /// </remarks>
        public Basket CreateBasket(Basket basket)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new shipment for a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="shipment">A Shipment document instance containing the shipment.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <remarks>
        /// <para>
        /// The created shipment is initialized with values provided in the body document and can be updated with further data API calls. Considered from the body are the following properties if specified:
        /// <list type="bullet">
        /// <item><description>the id</description></item>
        /// <item><description>the shipping address</description></item>
        /// <item><description>the shipping method</description></item>
        /// <item><description>gift boolean flag</description></item>
        /// <item><description>gift message</description></item>
        /// <item><description>custom properties</description></item>
        /// </list>
        /// </para>
        /// </remarks>
        public Basket CreateShipment(string basketId, Shipment shipment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <returns>A Basket document instance containing the requested basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket GetBasket(string basketId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves notes for a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <returns>A NotesResult instance containing the notes for the basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public NotesResult GetNotes(string basketId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets applicable payment methods for an existing basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <returns>A PaymentMethodResult document instance containing the payment methods.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public PaymentMethodResult GetPaymentMethods(string basketId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public void RemoveBasket(string basketId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a coupon from the basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="couponItemId">A String value containing the coupon item ID.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="couponItemId"/> is null or empty.</exception>
        public Basket RemoveCoupon(string basketId, string couponItemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a basket note.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="noteId">A String value containing the note ID.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="noteId"/> is null or empty.</exception>
        public Basket RemoveNote(string basketId, string noteId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a payment instrument of a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="paymentInstrumentId">A String value containing the payment instrument ID.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="paymentInstrumentId"/> is null or empty.</exception>
        public Basket RemovePaymentInstrument(string basketId, string paymentInstrumentId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a custom manual price adjustment from the basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="priceAdjustmentId">A String value containing the price adjustment ID.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="priceAdjustmentId"/> is null or empty.</exception>
        public Basket RemovePriceAdjustment(string basketId, string priceAdjustmentId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a product item from the basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="itemId">A String value containing the product item ID.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="itemId"/> is null or empty.</exception>
        public Basket RemoveProductItem(string basketId, string itemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a basket.
        /// </summary>
        /// <param name="basket">A Basket document instance containing the values for the basket.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <remarks>Only the currency of the basket and the custom properties of the basket and of the shipping items will be considered.</remarks>
        /// <exception cref="ArgumentException">Thrown when <paramref name="basket"/> does not contain a valid basket ID.</exception>
        public Basket UpdateBasket(Basket basket)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the billing address of a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="orderAddress">An OrderAddress document instance containing the address with or without a valid address ID.</param>
        /// <param name="useAsDefault">A Boolean value indicating whether the given address will also be used as shipping address for the default shipment.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket UpdateBillingAddress(string basketId, OrderAddress orderAddress, bool useAsDefault)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the customer information for an existing basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="customerInfo">A CustomerInfo document instance containing the customer information.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        public Basket UpdateCustomerInfo(string basketId, CustomerInfo customerInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a payment instrument of a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="paymentInstrumentId">A String value containing the payment instrument ID.</param>
        /// <param name="paymentInstrument">A BasketPaymentInstrumentRequest document instance containing the payment instrument.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="paymentInstrumentId"/> is null or empty.</exception>
        /// <remarks>Payment instruments are usually authorized after order creation, for example in a custom hook. The default payment authorization process executes an authorization when a payment instrument is added to an order or updated. See POST /orders/{order_no}/payment_instruments and PATCH /orders/{order_no}/payment_instruments/{payment_instrument_id}</remarks>
        public Basket UpdatePaymentInstrument(string basketId, string paymentInstrumentId, BasketPaymentInstrumentRequest paymentInstrument)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an item in a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="itemId">A String value containing the product item ID.</param>
        /// <param name="productItem">A ProductItem document instance containing the product item.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <remarks>
        /// <para>
        /// The following values in the request body are considered by the server:
        /// <list type="bullet">
        /// <item><term>product_id</term><definition>a valid product id. This is the id of the product to be added to the basket.</definition></item>
        /// <item><term>shipment_id</term><definition>a valid shipment id (optional). This is the id of the shipment in which the product item is created.</definition></item>
        /// <item><term>quantity</term><definition>a number between 0.01 and 999. This is the quantity of the product to order.</definition></item>
        /// <item><term>inventory_id</term><definition>a valid inventory id (optional). This is the id of the inventory from which the item is allocated.</definition></item>
        /// <item><term>option_items/option_value_id</term><definition>
        /// a valid option value id. This is an option value for an option item of an option product.
        /// <para>
        /// This is only possible if the product item is an option product. To set option values, you must specify a collection of option items in the option_items property. These option items must contain option_id and option_value_id. Also, the values you specify must be valid for the option product that this product item represents. Otherwise, the server throws an InvalidProductOptionItemException or an InvalidProductOptionValueItemException.</para>
        /// </definition></item>
        /// <item><term>custom properties in the form c_&lt;CUSTOM_NAME&gt;</term><definition>the custom property must correspond to a custom attribute (&lt;CUSTOM_NAME&gt;) defined for ProductLineItem. The value of this property must be valid for the type of custom attribute defined for ProductLineItem.</definition></item>
        /// </list>
        /// </para>
        /// </remarks>
        public Basket UpdateProductItem(string basketId, string itemId, ProductItem productItem)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a shipment for a basket.
        /// </summary>
        /// <param name="basketId">A String value containing the basket ID.</param>
        /// <param name="shipmentId">A String value containing the shipment ID.</param>
        /// <param name="shipment">A Shipment document instance containing the shipment.</param>
        /// <returns>A Basket document instance containing the updated basket.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="basketId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="shipmentId"/> is null or empty.</exception>
        /// <remarks>
        /// <para>
        /// The shipment is initialized with values provided in the body document and can be updated with further data API calls. Considered from the body are the following properties if specified
        /// <list type="bullet">
        /// <item><description>the id</description></item>
        /// <item><description>the shipping address</description></item>
        /// <item><description>the shipping method</description></item>
        /// <item><description>gift boolean flag</description></item>
        /// <item><description>gift message</description></item>
        /// <item><description>custom properties</description></item>
        /// </list>
        /// </para>
        /// </remarks>
        public Basket UpdateShipment(string basketId, string shipmentId, Shipment shipment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a shipping address of a specific shipment of a basket.
        /// </summary>
        /// <param name="basketId"></param>
        /// <param name="shipmentId"></param>
        /// <param name="orderAddress"></param>
        /// <param name="useAsBilling"></param>
        /// <returns></returns>
        public Basket UpdateShippingAddress(string basketId, string shipmentId, OrderAddress orderAddress, bool useAsBilling)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
