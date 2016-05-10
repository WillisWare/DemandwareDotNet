using System;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a product list event.
    /// </summary>
    public sealed class ProductListEvent
    {
        #region Properties

        /// <summary>
        /// The city where the event takes place.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// The country where the event takes place.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The date when the event takes place.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The federal state where the event takes place.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Type of the event to celebrate.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        #endregion
    }
}
