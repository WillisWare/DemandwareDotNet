using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents a password change request.
    /// </summary>
    public sealed class PasswordChangeRequest
    {
        #region Properties

        /// <summary>
        /// The customer's current password.
        /// </summary>
        [JsonProperty(PropertyName = "current_password", Required = Required.DisallowNull)]
        [StringLength(4096)]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// The customer's new password.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.DisallowNull)]
        [StringLength(4096)]
        public string NewPassword { get; set; }

        #endregion
    }
}
