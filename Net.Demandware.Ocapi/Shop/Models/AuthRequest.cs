using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Enumerates the valid types of auth request.
    /// </summary>
    public enum AuthRequestType
    {
        [EnumMember(Value = "guest")]
        Guest,

        [EnumMember(Value = "credentials")]
        Credentials,

        [EnumMember(Value = "refresh")]
        Refresh,

        [EnumMember(Value = "session")]
        Session
    }

    /// <summary>
    /// Represents the authentication request type.
    /// </summary>
    public sealed class AuthRequest
    {
        #region Properties

        /// <summary>
        /// Type of authentication request: guest, login (credentials), refresh or session.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public AuthRequestType Type { get; set; }

        #endregion
    }
}
