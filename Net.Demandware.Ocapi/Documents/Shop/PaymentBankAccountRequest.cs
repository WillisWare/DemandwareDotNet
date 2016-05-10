using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a payment bank account request.
    /// </summary>
    public sealed class PaymentBankAccountRequest
    {
        #region Properties

        /// <summary>
        /// The drivers license.
        /// </summary>
        [JsonProperty(PropertyName = "drivers_license")]
        [StringLength(256)]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// The drivers license state code.
        /// </summary>
        [JsonProperty(PropertyName = "drivers_license_state_code")]
        [StringLength(256)]
        public string DriversLicenseState { get; set; }

        /// <summary>
        /// The holder of the bank account.
        /// </summary>
        [JsonProperty(PropertyName = "holder")]
        [StringLength(256)]
        public string Holder { get; set; }

        /// <summary>
        /// The payment bank account number.
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        [StringLength(256)]
        public string Number { get; set; }

        #endregion
    }
}
