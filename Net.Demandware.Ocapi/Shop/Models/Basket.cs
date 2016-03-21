using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
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
    public sealed class Basket : BaseOrder
    {
        #region Properties

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

        #endregion
    }
}
