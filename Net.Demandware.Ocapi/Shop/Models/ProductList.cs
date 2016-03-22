using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Enumerates the valid product list types.
    /// </summary>
    public enum ProductListType
    {
        [EnumMember(Value = "wish_list")]
        WishList,

        [EnumMember(Value = "gift_registry")]
        GiftRegistry,

        [EnumMember(Value = "shopping_list")]
        ShoppingList,

        [EnumMember(Value = "custom_1")]
        Custom1,

        [EnumMember(Value = "custom_2")]
        Custom2,

        [EnumMember(Value = "custom_3")]
        Custom3
    }

    /// <summary>
    /// Represents a product list.
    /// </summary>
    public sealed class ProductList
    {
        #region Properties

        /// <summary>
        /// The coRegistrant of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "co_registrant")]
        public ProductListRegistrant CoRegistrant { get; set; }

        /// <summary>
        /// The resource link to the currentShippingAddress of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "current_shipping_address_link")]
        public AddressLink CurrentShippingAddressLink { get; set; }

        /// <summary>
        /// The description of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The event of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public ProductListEvent Event { get; set; }

        /// <summary>
        /// The id of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the owner made this product list available for access by other customers.
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// The resource link to the currentShippingAddress of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "items_link")]
        public ProductListItemLink ItemsLink { get; set; }

        /// <summary>
        /// The name of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The resource link to the postEventShippingAddress of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "post_event_shipping_address_link")]
        public AddressLink PostEventShippingAddressLink { get; set; }

        /// <summary>
        /// The abbreviated shipping address of this product list representing what anonymous user can see.
        /// </summary>
        [JsonProperty(PropertyName = "product_list_shipping_address")]
        public ProductListShippingAddress ProductListShippingAddress { get; set; }

        /// <summary>
        /// The registrant of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "registrant")]
        public ProductListRegistrant Registrant { get; set; }

        /// <summary>
        /// The resource link to the shippingAddress of this product list.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_address_link")]
        public AddressLink ShippingAddressLink { get; set; }

        /// <summary>
        /// The type of the product list.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ProductListType Type { get; set; }

        #endregion
    }
}
