using System.Configuration;

namespace Net.Demandware.Ocapi.Configuration
{
    /// <summary>
    /// Represents a configuration element containing OCAPI security information.
    /// </summary>
    public sealed class OcapiSecurityElement : ConfigurationElement
    {
        #region Members

        /// <summary>
        /// Specifies the attribute key of the Client ID property.
        /// </summary>
        public const string CLIENT_ID_KEY = "clientId";

        /// <summary>
        /// Specifies the name of the OAith Path element.
        /// </summary>
        public const string OAUTH_KEY = "oauthPath";

        /// <summary>
        /// Specifies the attribute key of the Password property.
        /// </summary>
        public const string PASSWORD_KEY = "password";

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Demandware client ID.
        /// </summary>
        [ConfigurationProperty(CLIENT_ID_KEY, IsRequired = true)]
        public string ClientId
        {
            get
            {
                return base[CLIENT_ID_KEY] as string;
            }
            set
            {
                base[CLIENT_ID_KEY] = value;
            }
        }

        /// <summary>
        /// Gets or sets the path to the OAuth token service.
        /// </summary>
        [ConfigurationProperty(OAUTH_KEY, IsRequired = false)]
        public OcapiNetworkPathElement OAuthPath
        {
            get
            {
                return (OcapiNetworkPathElement)base[OAUTH_KEY];
            }
            set
            {
                base[OAUTH_KEY] = value;
            }
        }

        /// <summary>
        /// Gets or sets the Demandware password.
        /// </summary>
        [ConfigurationProperty(PASSWORD_KEY, IsRequired = true)]
        public string Password
        {
            get
            {
                return base[PASSWORD_KEY] as string;
            }
            set
            {
                base[PASSWORD_KEY] = value;
            }
        }

        #endregion
    }
}
