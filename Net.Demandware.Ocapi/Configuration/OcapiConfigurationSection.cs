using System.Configuration;

namespace Net.Demandware.Ocapi.Configuration
{
    /// <summary>
    /// Represents a configuration section with values necessary for connecting to the OCAPI service.
    /// </summary>
    public sealed class OcapiConfigurationSection : ConfigurationSection
    {
        #region Members

        /// <summary>
        /// Specifies the name of the Credentials element.
        /// </summary>
        public const string CREDENTIALS_KEY = "credentials";

        /// <summary>
        /// Specifies the name of the Data API element.
        /// </summary>
        public const string DATA_API_KEY = "dataApi";

        /// <summary>
        /// Specifies the name of the Organizational API element.
        /// </summary>
        public const string ORG_API_KEY = "organizationApi";

        /// <summary>
        /// Specifies the name of the Shop API element.
        /// </summary>
        public const string SHOP_API_KEY = "shopApi";

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the credentials configuration.
        /// </summary>
        [ConfigurationProperty(CREDENTIALS_KEY, IsRequired = true)]
        public OcapiSecurityElement Credentials
        {
            get { return (OcapiSecurityElement)this[CREDENTIALS_KEY]; }
            set { this[CREDENTIALS_KEY] = value; }
        }

        /// <summary>
        /// Gets or sets the data API configuration.
        /// </summary>
        [ConfigurationProperty(DATA_API_KEY, IsRequired = true)]
        public OcapiNetworkPathElement DataApiConfiguration
        {
            get { return (OcapiNetworkPathElement)this[DATA_API_KEY]; }
            set { this[DATA_API_KEY] = value; }
        }

        /// <summary>
        /// Gets or sets the organizational API configuration.
        /// </summary>
        [ConfigurationProperty(ORG_API_KEY, IsRequired = true)]
        public OcapiNetworkPathElement OrganizationApiConfiguration
        {
            get { return (OcapiNetworkPathElement)this[ORG_API_KEY]; }
            set { this[ORG_API_KEY] = value; }
        }

        /// <summary>
        /// Gets or sets the shop API configuration.
        /// </summary>
        [ConfigurationProperty(SHOP_API_KEY, IsRequired = true)]
        public OcapiNetworkPathElement ShopApiConfiguration
        {
            get { return (OcapiNetworkPathElement)this[SHOP_API_KEY]; }
            set { this[SHOP_API_KEY] = value; }
        }

        #endregion
    }
}
