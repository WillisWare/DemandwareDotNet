using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Documents.Data;
using Net.Demandware.Ocapi.Exceptions;
using Net.Demandware.Ocapi.Extensions;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Data
{
    /// <summary>
    /// Contains API methods for customer searches.
    /// </summary>
    public sealed class CustomerSearch : BaseResource
    {
        #region Methods

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="request">A CustomerSearchRequest instance containing the search criteria.</param>
        /// <returns>A CustomerSearchResult instance containing the results of the customer search.</returns>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// The search can be configured using a simple query language, which provides most common filter and operator functionality.
        /// The identifier for an attribute to use in a query condition is always the ID of the attribute as defined in the type definition.
        /// For custom defined attributes the prefix "c_" is required in the search term (e.g. c_color = {1}), while for system attributes no prefix is used (e.g. name = {4}).
        /// </remarks>
        public CustomerSearchResult Search(CustomerSearchRequest request)
        {
            var authorization = GetOcapiAuthorizationToken();

            var searchUrl = $"{Configuration.DataApiConfiguration.Url}{BasePath}";

            var headers = GetWebHeaders(searchUrl, authorization);

            var searchResponse = ServiceManager.HttpPost<CustomerSearchResult>(searchUrl, headers, request.GetBytes());

            return searchResponse;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "customer_search/";

        #endregion
    }
}
