using System;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Exceptions;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to customers.
    /// </summary>
    /// <remarks>Uses JWT or an OAuth Business Manager user grant as authentication method.</remarks>
    public sealed class Customers : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the customers API for URL-building.
        /// </summary>
        private const string BASE_PATH = "customers/";

        #endregion

        #region Methods

        /// <summary>
        /// Registers a customer.
        /// </summary>
        /// <param name="customerRegistration">A CustomerRegistration document instance containing the customer information.</param>
        /// <returns>A Customer document instance containing the new customer.</returns>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// The mandatory data are the credentials and profile last name and email.
        /// When using OAuth the password in the request must not be set, otherwise an InvalidPasswordException will be thrown.
        /// When using JWT the password is required.
        /// </remarks>
        public Customer CreateCustomer(CustomerRegistration customerRegistration)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtains a new JWT (JSON Web Token) for a guest or registered customer.
        /// </summary>
        /// <param name="requestType">An AuthRequestType value indicating the request type.</param>
        /// <param name="userName">The username, if <paramref name="requestType"/> is "credentials."</param>
        /// <param name="password">The password, if <paramref name="requestType"/> is "credentials."</param>
        /// <returns>A Customer document instance containing the customer information.</returns>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// Tokens are returned as a HTTP Authorization:Bearer response header entry. These kinds of request are supported, as specified by the type:
        /// <list type="bullet">
        /// <item><term>guest</term><definition>creates a new guest (non-authenticated) customer and returns a token for the customer.</definition></item>
        /// <item><term>credentials</term><definition>authenticates credentials passed in the HTTP Authorization:Basic request header, returning a token for a successfully authenticated customer otherwise results in an AuthenticationFailedException.</definition></item>
        /// <item><term>session</term><definition>authenticates the customer (anonymous or registered) on base of dwsid and dwsecuretoken cookies. It returns a token for a successfully authenticated customer, otherwise results in an AuthenticationFailedException.</definition></item>
        /// <item><term>refresh</term><definition>examines the token passed in the HTTP Authorization:Bearer request header and when valid returns a new token with an updated expiry time.</definition></item>
        /// </list>
        /// <para>
        /// For a request of type credentials:
        /// <list type="bullet">
        /// <item><definition>Updates profile attributes for the customer (for example, "last-visited").</definition></item>
        /// <item><definition>Handles the maximum number of failed login attempts.</definition></item>
        /// </list>
        /// </para>
        /// <para>
        /// For a request of type session:
        /// <list type="bullet">
        /// <item><definition>Does not touch profile attributes for the registered customer (for example, "last-visited"), since this is not a real login.</definition></item>
        /// <item><definition>Returns different tokens for multiple requests with the same session id. Means, there should be only one call per session.</definition></item>
        /// </list>
        /// </para>
        /// </remarks>
        public Customer CreateJsonWebToken(AuthRequestType requestType, string userName = null, string password = null)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
