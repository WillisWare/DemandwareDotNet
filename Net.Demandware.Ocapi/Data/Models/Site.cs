using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a site.
    /// </summary>
    public sealed class Site : BaseClass
    {
        #region Properties

        /// <summary>
        /// The customerListLink.
        /// </summary>
        [JsonProperty(PropertyName = "customer_list_link")]
        public CustomerListLink CustomerListLink { get; set; }

        #endregion
    }
}
