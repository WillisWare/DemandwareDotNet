using System;
using System.Configuration;
using System.Net;
using System.Text;
using Net.Demandware.Ocapi.Configuration;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Extensions;
using Net.Demandware.Ocapi.Resources.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Resources.Base
{
    /// <summary>
    /// Contains the core functionality of a resource (service) class.
    /// </summary>
    public abstract class BaseResource
    {
        #region Members

        /// <summary>
        /// The local configuration instance containing connection information for the OCAPI service.
        /// </summary>
        private readonly OcapiConfigurationSection _configuration;

        #endregion

        #region Constructors

        /// <summary>
        /// Base constructor. Initializes configuration for the inheriting class.
        /// </summary>
        protected BaseResource()
        {
            _configuration = ConfigurationManager.GetSection("ocapiConfig") as OcapiConfigurationSection;
            if (_configuration?.Credentials == null)
            {
                throw new InvalidOperationException("A valid OCAPI configuration section must be defined.");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts an object to a JSON-serialized byte array for use as a request payload.
        /// </summary>
        /// <param name="value">An Object to be serialized.</param>
        /// <returns>The serialized object.</returns>
        protected byte[] GetBytes(object value)
        {
            var serializedValue = JsonConvert.SerializeObject(value);

            return Encoding.Default.GetBytes(serializedValue);
        }

        /// <summary>
        /// Gets the host name from the specified URL.
        /// </summary>
        /// <param name="url">A String value containing the URL.</param>
        /// <returns>A String value containing the URL's host name.</returns>
        protected static string GetHostHeader(string url)
        {
            var uri = new Uri(url);

            var host = uri.Host;

            return host;
        }

        /// <summary>
        /// Queries the Demandware OAuth service to obtain an access token for API calls.
        /// </summary>
        /// <returns>A String value containing the access token.</returns>
        protected string GetOcapiAuthorizationToken()
        {
            var authorization = $"{Configuration.Credentials.ClientId}:{Configuration.Credentials.Password}".EncodeTo64();
            var data = Encoding.Default.GetBytes(Constants.OCAPI_DATA);

            var headers = new WebHeaderCollection
            {
                [HttpRequestHeader.Authorization] = $"{Constants.BASIC_HEADER_PREFIX} {authorization}",
                [HttpRequestHeader.ContentType] = Constants.CONTENT_TYPE_FORM,
                [HttpRequestHeader.Host] = GetHostHeader(Configuration.Credentials.OAuthPath.Url)
            };

            var response = ServiceManager.HttpPost<dynamic>(Configuration.Credentials.OAuthPath.Url, headers, data);

            return (string)response.access_token;
        }

        /// <summary>
        /// Queries the Demandware OAuth service to obtain a JWT token for API calls.
        /// </summary>
        /// <returns>A String value containing the JWT token.</returns>
        protected string GetOcapiJwtToken()
        {
            const string JSON_REQUEST_BODY = "{\"type\":\"guest\"}";

            var data = Encoding.Default.GetBytes(JSON_REQUEST_BODY);

            var headers = new WebHeaderCollection
            {
                [HttpRequestHeader.ContentType] = Constants.CONTENT_TYPE_JSON,
                [HttpRequestHeader.Host] = GetHostHeader(Configuration.ShopApiConfiguration.Url),
                [Constants.OCAPI_CLIENT_HEADER] = Configuration.Credentials.ClientId
            };

            ServiceManager.HttpPost<JwtToken>(Configuration.ShopApiConfiguration.Url, headers, data);

            var authorization = headers[HttpRequestHeader.Authorization];
            if (string.IsNullOrEmpty(authorization))
            {
                throw new InvalidOperationException();
            }

            var values = authorization.Split(' ');

            return values[1];
        }

        /// <summary>
        /// Assembles a WebHeaderCollection containing the common headers for an unauthenticated Demandware API call.
        /// </summary>
        /// <param name="url">A String value containing the URL.</param>
        /// <returns>A WebHeaderCollection instance containing the common headers.</returns>
        protected WebHeaderCollection GetWebHeaders(string url)
        {
            var headers = new WebHeaderCollection
            {
                [HttpRequestHeader.Accept] = Constants.CONTENT_TYPE_JSON,
                [HttpRequestHeader.ContentType] = Constants.CONTENT_TYPE_JSON,
                [HttpRequestHeader.Host] = GetHostHeader(url)
            };
            return headers;
        }

        /// <summary>
        /// Assembles a WebHeaderCollection containing the common headers for a Demandware API call.
        /// </summary>
        /// <param name="url">A String value containing the URL.</param>
        /// <param name="authorization">A String value containing the DW authorization token.</param>
        /// <returns>A WebHeaderCollection instance containing the common headers.</returns>
        protected WebHeaderCollection GetWebHeaders(string url, string authorization)
        {
            var headers = new WebHeaderCollection
            {
                [HttpRequestHeader.Accept] = Constants.CONTENT_TYPE_JSON,
                [HttpRequestHeader.Authorization] = $"{Constants.BEARER_HEADER_PREFIX} {authorization}",
                [HttpRequestHeader.ContentType] = Constants.CONTENT_TYPE_JSON,
                [HttpRequestHeader.Host] = GetHostHeader(url),
                [Constants.OCAPI_CLIENT_HEADER] = Configuration.Credentials.ClientId
            };
            return headers;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the configuration instance containing connection information for the OCAPI service.
        /// </summary>
        protected OcapiConfigurationSection Configuration => _configuration;

        /// <summary>
        /// Gets a singleton instance of ServiceManager for performing API calls.
        /// </summary>
        protected ServiceManager ServiceManager { get; } = ServiceManager.GetInstance();

        #endregion
    }
}
