using System.Collections.Generic;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid site statuses.
    /// </summary>
    public enum SiteStatus
    {
        [EnumMember(Value = "online")]
        Online,

        [EnumMember(Value = "offline")]
        Offline
    }

    /// <summary>
    /// Represents a site.
    /// </summary>
    public sealed class Site : BaseClass
    {
        #region Properties

        /// <summary>
        /// The list of allowed currencies.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_currencies")]
        public IEnumerable<string> AllowedCurrencies { get; set; }

        /// <summary>
        /// A list of all allowed site locales.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_locales")]
        public IEnumerable<string> AllowedLocales { get; set; }

        /// <summary>
        /// The currency mnemonic of the site.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The default locale of the site.
        /// </summary>
        [JsonProperty(PropertyName = "default_locale")]
        public string DefaultLocale { get; set; }

        /// <summary>
        /// The configured HTTP host name.
        /// </summary>
        /// <remarks>If no host name is configured the instance host name is returned.</remarks>
        [JsonProperty(PropertyName = "http_hostname")]
        public string HttpHostname { get; set; }

        /// <summary>
        /// The HTTP URL to the library content location of the site.
        /// </summary>
        [JsonProperty(PropertyName = "http_library_content_url")]
        public string HttpLibraryContentUrl { get; set; }

        /// <summary>
        /// The HTTP URL to the site content location.
        /// </summary>
        [JsonProperty(PropertyName = "http_site_content_url")]
        public string HttpSiteContentUrl { get; set; }

        /// <summary>
        /// The configured HTTPS host name.
        /// </summary>
        /// <remarks>If no host name is configured the instance host name is returned.</remarks>
        [JsonProperty(PropertyName = "https_hostname")]
        public string HttpsHostname { get; set; }

        /// <summary>
        /// The HTTPS URL to the library content location of the site.
        /// </summary>
        [JsonProperty(PropertyName = "https_library_content_url")]
        public string HttpsLibraryContentUrl { get; set; }

        /// <summary>
        /// The HTTPS URL to the site content location.
        /// </summary>
        [JsonProperty(PropertyName = "https_site_content_url")]
        public string HttpsSiteContentUrl { get; set; }

        /// <summary>
        /// The descriptive name for the site.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The site status online/offline.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public SiteStatus Status { get; set; }

        /// <summary>
        /// The time zone of the site (for example, USA/Eastern).
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// The time zone offset from UTC for the current time in milliseconds (for example, -14400000).
        /// </summary>
        [JsonProperty(PropertyName = "timezone_offset")]
        public int TimezoneOffset { get; set; }

        #endregion
    }
}
