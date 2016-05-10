using System.Configuration;

namespace Net.Demandware.Ocapi.Configuration
{
    /// <summary>
    /// Represents a configuration element containing network path information.
    /// </summary>
    public sealed class OcapiNetworkPathElement : ConfigurationElement
    {
        #region Members

        /// <summary>
        /// Specifies the attribute key for the URL property.
        /// </summary>
        public const string URL_KEY = "url";

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [ConfigurationProperty(URL_KEY, IsRequired = true)]
        public string Url
        {
            get
            {
                return base[URL_KEY] as string;
            }
            set
            {
                base[URL_KEY] = value;
            }
        }

        #endregion
    }
}
