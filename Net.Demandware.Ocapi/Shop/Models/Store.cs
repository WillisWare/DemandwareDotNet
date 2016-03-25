using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Represents a store.
    /// </summary>
    public sealed class Store : BaseStore
    {
        #region Properties

        /// <summary>
        /// The distance to the given geo location in the unit of attribute distance (miles or kilometers).
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public decimal Distance { get; set; }

        /// <summary>
        /// The distance unit the distance attribute is measured in (either in miles or kilometers).
        /// </summary>
        [JsonProperty(PropertyName = "distance_unit")]
        public string DistanceUnit { get; set; }

        #endregion
    }
}
