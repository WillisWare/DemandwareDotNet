namespace Net.Demandware.Ocapi
{
    /// <summary>
    /// Contains constant values for the project.
    /// </summary>
    internal static class Constants
    {
        #region Members

        internal const string BASIC_HEADER_PREFIX = "Basic";

        internal const string BEARER_HEADER_PREFIX = "Bearer";

        internal const string CONTENT_TYPE_FORM = "application/x-www-form-urlencoded";

        internal const string CONTENT_TYPE_JSON = "application/json";

        internal const string DEMANDWARE_ETAG_HEADER = "ETag";

        internal const string JWT_DATA = "{\"type\":\"guest\"}";

        internal const string OCAPI_CLIENT_HEADER = "x-dw-client-id";

        internal const string OCAPI_DATA = "grant_type=client_credentials";

        #endregion
    }
}
