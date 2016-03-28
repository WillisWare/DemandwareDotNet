using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a result containing an array of customer addresses.
    /// </summary>
    public sealed class CustomerAddressResult : BasePagedResult<CustomerAddress>
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
