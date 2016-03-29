using System.Configuration;

namespace Net.Demandware.Ocapi.Configuration
{
    /// <summary>
    /// Represents a configuration element containing network path information.
    /// </summary>
    public sealed class OcapiNetworkPathElement : ConfigurationElement
    {
        #region Properties

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [ConfigurationProperty("url", IsRequired = true)]
        public string Url { get; set; }

        #endregion
    }
}
