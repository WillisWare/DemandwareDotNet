using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid authorization types for a customer.
    /// </summary>
    public enum CustomerAuthType
    {
        [EnumMember(Value = "guest")]
        Guest,

        [EnumMember(Value = "registered")]
        Registered
    }

    /// <summary>
    /// Represents a customer.
    /// </summary>
    public sealed class Customer : BaseCustomer
    {
        #region Properties

        /// <summary>
        /// The customer's addresses.
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public IEnumerable<CustomerAddress> Addresses { get; set; }

        /// <summary>
        /// The customer's authorization type (indicates if the customer is a guest or a registered customer).
        /// </summary>
        [JsonProperty(PropertyName = "auth_type")]
        public CustomerAuthType AuthType { get; set; }

        /// <summary>
        /// A flag indicating whether this customer is enabled and can log in.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The customer's login.
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        [StringLength(256)]
        public string Login { get; set; }

        /// <summary>
        /// The customer's payment instruments.
        /// </summary>
        [JsonProperty(PropertyName = "payment_instruments")]
        public IEnumerable<CustomerPaymentInstrument> PaymentInstruments { get; set; }

        #endregion
    }
}
