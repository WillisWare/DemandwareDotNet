using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using Net.Demandware.Ocapi.Extensions;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Resources.Common
{
    /// <summary>
    /// Marshals service calls to the Demandware API for all resources.
    /// </summary>
    public sealed class ServiceManager
    {
        #region Members

        /// <summary>
        /// The singleton instance of ServiceManager.
        /// </summary>
        private static ServiceManager _manager;

        #endregion

        #region Constructors

        /// <summary>
        /// Private constructor that enables the singleton pattern for this class.
        /// </summary>
        private ServiceManager()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a singleton instance of ServiceManager.
        /// </summary>
        internal static ServiceManager GetInstance() => _manager ?? (_manager = new ServiceManager());

        /// <summary>
        /// Converts an object to a NameValueCollection to facilitate a PATCH request.
        /// </summary>
        /// <param name="source">An Object (class) instance containing the properties to be converted to name/value pairs.</param>
        /// <returns>A NameValueCollection instance containing the object properties.</returns>
        internal static NameValueCollection ConvertObjectToNameValueCollection(object source)
        {
            if (source == null)
            {
                return null;
            }

            var returnValue = new NameValueCollection();

            foreach (var property in source.GetType().GetProperties())
            {
                var propertyName = property.Name;
                var value = property.GetValue(source);

                var customAttributes = property.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (customAttributes.Length > 0)
                {
                    var attribute = customAttributes[0] as JsonPropertyAttribute;
                    if (attribute != null)
                    {
                        if (attribute.NullValueHandling == NullValueHandling.Ignore && value == null)
                        {
                            continue;
                        }

                        propertyName = attribute.PropertyName;
                    }
                }
                else
                {
                    customAttributes = property.GetCustomAttributes(typeof(DataMemberAttribute), false);
                    if (customAttributes.Length > 0)
                    {
                        propertyName = ((DataMemberAttribute)customAttributes[0]).Name;
                    }
                }

                if (value != null && (value.GetType().IsPrimitive || value is string || value is DateTime))
                {
                    returnValue.Add(propertyName, value.ToString());
                }
            }

            return returnValue;
        }

        internal string HttpPatch(string url, WebHeaderCollection webHeaderCollection, byte[] data)
        {
            var result = string.Empty;

            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Headers = webHeaderCollection;

                    var returnValue = webClient.UploadData(url, "PATCH", data);

                    SetResponseHeaders(webClient.ResponseHeaders, webHeaderCollection);

                    result = Encoding.ASCII.GetString(returnValue);
                }
            }
            catch (WebException we)
            {
                var responseBody = string.Empty;
                if (we.Response != null)
                {
                    using (var reader = new StreamReader(we.Response.GetResponseStream()))
                    {
                        responseBody = reader.ReadToEnd();
                    }

                    result = responseBody;
                }

                Trace.TraceError($"{we.Message}{responseBody.PrependIfNotNullOrEmpty(": ")}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }

            return result;
        }

        internal string HttpPatch(string url, WebHeaderCollection webHeaderCollection, NameValueCollection values)
        {
            var result = string.Empty;

            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Headers = webHeaderCollection;

                    var returnValue = webClient.UploadValues(url, "PATCH", values);

                    SetResponseHeaders(webClient.ResponseHeaders, webHeaderCollection);

                    result = Encoding.ASCII.GetString(returnValue);
                }
            }
            catch (WebException we)
            {
                var responseBody = string.Empty;
                if (we.Response != null)
                {
                    using (var reader = new StreamReader(we.Response.GetResponseStream()))
                    {
                        responseBody = reader.ReadToEnd();
                    }

                    result = responseBody;
                }

                Trace.TraceError($"{we.Message}{responseBody.PrependIfNotNullOrEmpty(": ")}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }

            return result;
        }

        internal string HttpPost(string url, WebHeaderCollection webHeaderCollection, byte[] data)
        {
            var result = string.Empty;

            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Headers = webHeaderCollection;

                    var returnValue = webClient.UploadData(url, "POST", data);

                    SetResponseHeaders(webClient.ResponseHeaders, webHeaderCollection);

                    result = Encoding.ASCII.GetString(returnValue);
                }
            }
            catch (WebException we)
            {
                var responseBody = string.Empty;
                if (we.Response != null)
                {
                    using (var reader = new StreamReader(we.Response.GetResponseStream()))
                    {
                        responseBody = reader.ReadToEnd();
                    }

                    result = responseBody;
                }

                Trace.TraceError($"{we.Message}{responseBody.PrependIfNotNullOrEmpty(": ")}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }

            return result;
        }

        internal string HttpGet(string url, WebHeaderCollection webHeaderCollection)
        {
            var result = string.Empty;

            try
            {
                using (var webClient = new WebClient())
                {
                    if (webHeaderCollection != null)
                    {
                        webClient.Headers = webHeaderCollection;
                    }

                    result = webClient.DownloadString(url);

                    SetResponseHeaders(webClient.ResponseHeaders, webHeaderCollection);
                }
            }
            catch (WebException we)
            {
                var responseBody = string.Empty;
                if (we.Response != null)
                {
                    using (var reader = new StreamReader(we.Response.GetResponseStream()))
                    {
                        responseBody = reader.ReadToEnd();
                    }

                    result = responseBody;
                }

                Trace.TraceError($"{we.Message}{responseBody.PrependIfNotNullOrEmpty(": ")}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }

            return result;
        }

        private static void SetResponseHeaders(NameValueCollection responseHeaders, NameValueCollection requestHeaders)
        {
            const string KEY_ETAG = "ETag";

            if (requestHeaders == null)
            {
                return;
            }

            if (responseHeaders.AllKeys.Contains(HttpRequestHeader.Authorization.ToString()))
            {
                requestHeaders[HttpRequestHeader.Authorization.ToString()] = responseHeaders[HttpRequestHeader.Authorization.ToString()];
            }

            if (responseHeaders.AllKeys.Contains(KEY_ETAG))
            {
                requestHeaders.Add(KEY_ETAG, responseHeaders[KEY_ETAG]);
            }
        }

        #endregion
    }
}
