using System;
using System.Linq;
using System.Net;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Exceptions;
using Net.Demandware.Ocapi.Extensions;
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
        /// Obtains a new agent on behalf token for a registered customer.
        /// </summary>
        /// <param name="customerId">Specifies the customer to act on behalf of.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// Token is returned as a HTTP Authorization:Bearer response header entry.
        /// A token is created and returned to the client whenever an agent with Create_Order_On_Behalf_Of permission calls the resource for a registered customer.
        /// The token is returned in the response header as Authorization: Bearer --token--.
        /// The client has to include the token in the request header as Authorization: Bearer --token-- in any follow up request, the agent will do on behalf of the customer.
        /// </remarks>
        public string CreateAgentOnBehalfOfCustomerToken(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            var tokenUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}{customerId}/auth?client_id={Configuration.Credentials.ClientId}";

            var headers = GetWebHeaders(tokenUrl, Configuration.Credentials.ClientId);

            ServiceManager.HttpPost<Customer>(tokenUrl, headers, null);

            var authorization = headers[HttpRequestHeader.Authorization];
            if (string.IsNullOrEmpty(authorization))
            {
                throw new InvalidOperationException();
            }

            // Authorization header comes back as "Bearer eyJfdiI6IjEiLCJhbGciOiJSUzI1NiIsInR5cCI6IkpXUyJ9..."
            var values = authorization.Split(' ');

            return values.LastOrDefault();
        }

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
        /// Creates a new address with the given name for the given customer.
        /// </summary>
        /// <param name="customerId">The ID of the customer to create the address for.</param>
        /// <param name="customerAddress">A CustomerAddress document instance containing the address information.</param>
        /// <returns>A CustomerAddress document instance containing the new address.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public CustomerAddress CreateCustomerAddress(string customerId, CustomerAddress customerAddress)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a payment instrument to a customer information.
        /// </summary>
        /// <param name="customerId">The ID of the customer.</param>
        /// <param name="customerPaymentInstrumentRequest">A CustomerPaymentInstrumentRequest document instance containing the payment instrument.</param>
        /// <returns>A CustomerPaymentInstrument document instance containing the new payment instrument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public CustomerPaymentInstrument CreateCustomerPaymentInstrument(string customerId, CustomerPaymentInstrumentRequest customerPaymentInstrumentRequest)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtains a new JWT (JSON Web Token) for a guest or registered customer.
        /// </summary>
        /// <param name="requestType">An AuthRequestType value indicating the request type.</param>
        /// <param name="userName">The username, if <paramref name="requestType"/> is "credentials."</param>
        /// <param name="password">The password, if <paramref name="requestType"/> is "credentials."</param>
        /// <returns>A String value containing the token.</returns>
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
        public string CreateJsonWebToken(AuthRequestType requestType, string userName = null, string password = null)
        {
            var requestBody = $"{{\"type\":\"{requestType.GetEnumMemberValue()}\"}}";

            var customerAuthUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}auth?client_id={Configuration.Credentials.ClientId}";

            var headers = GetWebHeaders(customerAuthUrl);

            ServiceManager.HttpPost<JwtToken>(customerAuthUrl, headers, GetBytes(requestBody));

            var authorization = headers[HttpRequestHeader.Authorization];
            if (string.IsNullOrEmpty(authorization))
            {
                throw new InvalidOperationException();
            }

            // Authorization header comes back as "Basic QWxhZGRpbjpvcGVuIHNlc2FtZQ==" or "Bearer eyJfdiI6IjXXXXXX.eyJfdiI6IjEiLCJleHAXXXXXXX.-d5wQW4c4O4wt-Zkl7_fiEiALW1XXXX"
            var values = authorization.Split(' ');

            return values.LastOrDefault();
        }

        /// <summary>
        /// Deletes a customer's address by address name.
        /// </summary>
        /// <param name="customerId">The ID of the customer to delete the address for.</param>
        /// <param name="addressName">The name of the address to delete.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="addressName"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public void DeleteCustomerAddress(string customerId, string addressName)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            if (string.IsNullOrEmpty(addressName))
            {
                throw new ArgumentNullException(nameof(addressName), Properties.Resources.Error_Missing_Address_Name);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a customer.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="expand">The expand parameter. A comma separated list with the allowed values (addresses, paymentinstruments).</param>
        /// <returns>A Customer document instance containing the customer information.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public Customer GetCustomer(string customerId, string expand)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a sorted pageable list of all customer addresses in the address book.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="count">The maximum number of instances per request. Default value is 25.</param>
        /// <param name="start">The result set index to return the first instance for. Default value is 0.</param>
        /// <returns>A CustomerAddressResult document instance containing the addresses.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// The default page size is 10 customer addresses. The addresses are sorted so that the preferred address is always sorted first. The remaining addresses are sorted alphabetically by ID.
        /// </remarks>
        public CustomerAddressResult GetMultipleAddresses(string customerId, int count = 25, int start = 0)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the baskets of a customer.
        /// </summary>
        /// <param name="customerId">The ID of the customer to retrieve the baskets for.</param>
        /// <returns>A BasketsResult document instance containing the baskets.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public BasketsResult GetMultipleBaskets(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a pageable list of all customer's orders.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="count">The maximum number of instances per request; default value is 10.</param>
        /// <param name="start">The result set index to return the first instance for; default value is 0.</param>
        /// <returns>A CustomerOrderResult document instance containing the orders.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public CustomerOrderResult GetMultipleOrders(string customerId, int count = 10, int start = 0)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets customer payment instruments for an customer.
        /// </summary>
        /// <param name="customerId">The ID of the customer to retrieve the payment instruments for.</param>
        /// <param name="paymentMethodId">The ID of the payment method, if null - all payment instruments are retrieved.</param>
        /// <returns>A CustomerPaymentInstrumentResult document instance containing the payment instruments.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>Can be limited to a specific payment method by providing query parameter payment_method_id.</remarks>
        public CustomerPaymentInstrumentResult GetMultiplePaymentInstruments(string customerId, string paymentMethodId = null)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a customer's address by address name.
        /// </summary>
        /// <param name="customerId">The ID of the customer to retrieve the address for.</param>
        /// <param name="addressName">The name of the address to retrieve.</param>
        /// <returns>A CustomerAddress document instance containing the address.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="addressName"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public CustomerAddress GetSingleAddress(string customerId, string addressName)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            if (string.IsNullOrEmpty(addressName))
            {
                throw new ArgumentNullException(nameof(addressName), Properties.Resources.Error_Missing_Address_Name);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts a password reset process.
        /// </summary>
        /// <param name="customerId">The ID of the customer.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// A password reset token is generated and passed together with the customer resolved by the id provided as path parameter to a putPasswordReset hook.
        /// The hook dw.ocapi.shop.customer.putPasswordReset needs to take care of resetting the password.
        /// </remarks>
        public void ResetCustomerPassword(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts a password reset process.
        /// </summary>
        /// <param name="passwordResetRequest">A PasswordResetRequest document instance containing the request information.</param>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// A password reset token is generated and together with the resolved customer is passed to a postPasswordReset hook.
        /// The customer resolution is based on the password reset request type. Currently the resolution can be done by email or login.
        /// In case of an email the password reset hook is only executed if one and only one customer has been identified for that email.
        /// In the case that more than one customers have been identified for the provided email the resource does nothing.
        /// </remarks>
        public void ResetPassword(PasswordResetRequest passwordResetRequest)
        {
            var passwordResetUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}password_reset";

            var headers = GetWebHeaders(passwordResetUrl, Configuration.Credentials.ClientId);

            var response = ServiceManager.HttpPost<Fault>(passwordResetUrl, headers, GetBytes(passwordResetRequest));
            if (response != null)
            {
                throw new ApiException(response);
            }
        }

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customer">A Customer document instance containing the customer information.</param>
        /// <returns>A Customer document instance containing the updated customer.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customer"/> contains a null or empty customer ID.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public Customer UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer?.Id))
            {
                throw new ArgumentNullException(nameof(customer), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a customer's address by address name.
        /// </summary>
        /// <param name="customerId">The ID of the customer to update the address for.</param>
        /// <param name="customerAddress">The name of the address to update.</param>
        /// <returns>A CustomerAddress document instance containing the updated address.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerAddress"/>.Id is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public CustomerAddress UpdateCustomerAddress(string customerId, CustomerAddress customerAddress)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            if (string.IsNullOrEmpty(customerAddress?.Id))
            {
                throw new ArgumentNullException(nameof(customerAddress), Properties.Resources.Error_Missing_Address_Name);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the customer's password.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="passwordChangeRequest">A PasswordChangeRequest document instance containing the new password.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="customerId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public void UpdateCustomerPassword(string customerId, PasswordChangeRequest passwordChangeRequest)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentNullException(nameof(customerId), Properties.Resources.Error_Missing_Customer_ID);
            }

            throw new NotImplementedException();
        }

        #endregion
    }
}
