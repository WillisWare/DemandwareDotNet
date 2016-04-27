using System.Configuration;

namespace Net.Demandware.Ocapi.Configuration
{
    /// <summary>
    /// Represents a configuration section with values necessary for connecting to the OCAPI service.
    /// </summary>
    public sealed class OcapiConfigurationSection : ConfigurationSection
    {
        #region Properties

        /// <summary>
        /// Gets or sets the credentials configuration.
        /// </summary>
        [ConfigurationProperty("credentials", IsRequired = true)]
        public OcapiSecurityElement Credentials
        {
            get { return (OcapiSecurityElement)this["credentials"]; }
            set { this["credentials"] = value; }
        }

        /// <summary>
        /// Gets or sets the data API configuration.
        /// </summary>
        [ConfigurationProperty("dataApi", IsRequired = true)]
        public OcapiNetworkPathElement DataApiConfiguration
        {
            get { return (OcapiNetworkPathElement)this["dataApi"]; }
            set { this["dataApi"] = value; }
        }

        /// <summary>
        /// Gets or sets the shop API configuration.
        /// </summary>
        [ConfigurationProperty("shopApi", IsRequired = true)]
        public OcapiNetworkPathElement ShopApiConfiguration
        {
            get { return (OcapiNetworkPathElement)this["shopApi"]; }
            set { this["shopApi"] = value; }
        }

        #endregion
    }
}
