using Net.Demandware.Ocapi.Documents.Data;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Data
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class CustomerSearch : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the customers API for URL-building.
        /// </summary>
        private const string BASE_PATH = "customer_search";

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CustomerSearchResult Search(CustomerSearchRequest request)
        {
            var authorization = GetOcapiAuthorizationToken();

            var searchUrl = $"{Configuration.DataApiConfiguration.Url}{BASE_PATH}";

            var headers = GetWebHeaders(searchUrl, authorization);

            var searchResponse = ServiceManager.HttpPost<CustomerSearchResult>(searchUrl, headers, GetBytes(request));

            return searchResponse;
        }

        #endregion
    }
}
