using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid product list item types.
    /// </summary>
    public enum ProductListItemType
    {
        [EnumMember(Value = "product")]
        Product,

        [EnumMember(Value = "gift_certificate")]
        GiftCertificate
    }

    /// <summary>
    /// Represents a product list item.
    /// </summary>
    public sealed class ProductListItem
    {
        #region Properties

        /// <summary>
        /// The id of this product list item.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// A flag indicating whether the owner made this product list item available for access by other customers.
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// The priority of the item.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }

        /// <summary>
        /// A link to the product.
        /// </summary>
        [JsonProperty(PropertyName = "product_details_link")]
        public ProductDetailsLink ProductDetailsLink { get; set; }

        /// <summary>
        /// The quantity of products already purchased.
        /// </summary>
        [JsonProperty(PropertyName = "purchased_quantity")]
        public decimal PurchasedQuantity { get; set; }

        /// <summary>
        /// The quantity of this item on the product list.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ProductListItemType Type { get; set; }

        #endregion
    }
}
