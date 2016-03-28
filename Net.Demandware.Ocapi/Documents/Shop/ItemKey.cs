using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents an item key.
    /// </summary>
    /// <remarks>
    /// The item can be either identified by its item id (item_id) or by its product id (product_id). If both are returned, the item that is identified by item_id must also have its product_id set.
    /// The item id for an item is unique in its parent container.However, the parent container can have multiple items with one product id.
    /// </remarks>
    public sealed class ItemKey
    {
        #region Properties

        /// <summary>
        /// The item id.
        /// </summary>
        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// The product id.
        /// </summary>
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        #endregion
    }
}
