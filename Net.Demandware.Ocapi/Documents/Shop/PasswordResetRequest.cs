using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid types of password reset identification.
    /// </summary>
    public enum PasswordResetIdentificationType
    {
        /// <summary>
        /// Indicates an e-mail type.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Indicates a login type.
        /// </summary>
        [EnumMember(Value = "login")]
        Login
    }

    /// <summary>
    /// Represents a password reset request.
    /// </summary>
    public sealed class PasswordResetRequest
    {
        #region Properties

        /// <summary>
        /// The customer's login or the customer's email depending on the type value.
        /// </summary>
        [JsonProperty(PropertyName = "identification")]
        public string Identification { get; set; }

        /// <summary>
        /// The type of customer identification.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public PasswordResetIdentificationType Type { get; set; }

        #endregion
    }
}
