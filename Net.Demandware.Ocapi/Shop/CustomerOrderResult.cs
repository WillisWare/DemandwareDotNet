using Net.Demandware.Ocapi.BaseModels;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents a result containing an array of customer orders.
    /// </summary>
    public sealed class CustomerOrderResult : BasePagedResult<Order>
    {
        #region Properties

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        #endregion
    }
}
