using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents the credentials of a customer.
    /// </summary>
    public sealed class Credentials
    {
        #region Properties

        /// <summary>
        /// A flag indicating whether the customer is enabled and can log.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// A flag indicating whether the customer account is locked.
        /// </summary>
        [JsonProperty(PropertyName = "locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// The login of the customer.
        /// </summary>
        [JsonProperty(PropertyName = "login", Required = Required.DisallowNull)]
        [StringLength(256)]
        public string Login { get; set; }

        /// <summary>
        /// The password question.
        /// </summary>
        [JsonProperty(PropertyName = "password_question")]
        [StringLength(256)]
        public string PasswordQuestion { get; set; }

        #endregion
    }
}
