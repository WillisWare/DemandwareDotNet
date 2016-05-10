using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a payment bank account.
    /// </summary>
    public sealed class PaymentBankAccount
    {
        #region Properties

        /// <summary>
        /// The last 4 characters of the decrypted driver's license number of the bank account associated with this payment instrument.
        /// </summary>
        [JsonProperty(PropertyName = "drivers_license_last_digits")]
        [StringLength(256)]
        public string DriversLicenseLastDigits { get; set; }

        /// <summary>
        /// The decrypted driver's license number of the bank account with all but the last 4 characters replaced with a '*' character.
        /// </summary>
        [JsonProperty(PropertyName = "masked_drivers_license")]
        [StringLength(256)]
        public string DriversLicenseNumberMasked { get; set; }

        /// <summary>
        /// The driver license state code.
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
        /// The last digits of the bank account number.
        /// </summary>
        [JsonProperty(PropertyName = "number_last_digits")]
        [StringLength(256)]
        public string LastDigits { get; set; }

        /// <summary>
        /// The bank account masked number.
        /// </summary>
        [JsonProperty(PropertyName = "masked_number")]
        [StringLength(256)]
        public string NumberMasked { get; set; }

        #endregion
    }
}
