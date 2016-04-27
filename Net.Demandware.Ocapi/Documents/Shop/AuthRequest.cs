using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid types of auth request.
    /// </summary>
    public enum AuthRequestType
    {
        /// <summary>
        /// Indicates a guest authorization.
        /// </summary>
        [EnumMember(Value = "guest")]
        Guest,

        /// <summary>
        /// Indicates a credentials authorization.
        /// </summary>
        [EnumMember(Value = "credentials")]
        Credentials,

        /// <summary>
        /// Indicates a refresh authorization.
        /// </summary>
        [EnumMember(Value = "refresh")]
        Refresh,

        /// <summary>
        /// Indicates a session authorization.
        /// </summary>
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
