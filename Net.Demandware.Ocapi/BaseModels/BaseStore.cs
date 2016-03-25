using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Represents the basic structure of a store.
    /// </summary>
    public abstract class BaseStore : BaseClass
    {
        #region Properties

        /// <summary>
        /// The first address of the store.
        /// </summary>
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The second address of the store.
        /// </summary>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city of the store.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// The country code of the store.
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The email address of the store.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The store events.
        /// </summary>
        [JsonProperty(PropertyName = "store_events")]
        public string Events { get; set; }

        /// <summary>
        /// The fax number of the store.
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// The store opening hours.
        /// </summary>
        [JsonProperty(PropertyName = "store_hours")]
        public string Hours { get; set; }

        /// <summary>
        /// The store image.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// The inventory list id associated with this store.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_id")]
        [StringLength(256)]
        public string InventoryId { get; set; }

        /// <summary>
        /// The latitude of the store.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        [Range(-90.0, 90.0)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// The longitude of the store.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        [Range(-180.0, 180.0)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// The store name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the store.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The postal code of the store.
        /// </summary>
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state code of the store.
        /// </summary>
        [JsonProperty(PropertyName = "state_code")]
        public string StateCode { get; set; }

        #endregion
    }
}
