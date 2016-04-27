using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Common
{
    /// <summary>
    /// Represents a Java Web Token structure used for authentication.
    /// </summary>
    public sealed class JwtToken
    {
        #region Properties

        /// <summary>
        /// Gets or sets the JWT authorization type.
        /// </summary>
        [JsonProperty(PropertyName = "auth_type")]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        [JsonProperty(PropertyName = "customer_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the preferred locale.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the JWT type.
        /// </summary>
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the token version.
        /// </summary>
        [JsonProperty(PropertyName = "_v")]
        public string Version { get; set; }

        #endregion
    }
}
