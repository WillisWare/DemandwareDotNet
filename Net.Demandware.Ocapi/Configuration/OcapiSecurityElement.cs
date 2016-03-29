using System.Configuration;

namespace Net.Demandware.Ocapi.Configuration
{
    /// <summary>
    /// Represents a configuration element containing OCAPI security information.
    /// </summary>
    public sealed class OcapiSecurityElement : ConfigurationElement
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Demandware client ID.
        /// </summary>
        [ConfigurationProperty("clientId", IsRequired = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the path to the OAuth token service.
        /// </summary>
        [ConfigurationProperty("oauthPath", IsRequired = false)]
        public OcapiNetworkPathElement OAuthPath { get; set; }

        /// <summary>
        /// Gets or sets the Demandware password.
        /// </summary>
        [ConfigurationProperty("password", IsRequired = true)]
        public string Password { get; set; }

        #endregion
    }
}
