using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    public sealed class Customer : BaseCustomer
    {
        #region Properties

        /// <summary>
        /// The customer's credentials.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public Credentials Credentials { get; set; }

        #endregion
    }
}
