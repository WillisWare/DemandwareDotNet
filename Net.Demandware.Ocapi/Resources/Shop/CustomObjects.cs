using System;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Exceptions;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to custom objects.
    /// </summary>
    public sealed class CustomObjects : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the baskets API for URL-building.
        /// </summary>
        private const string BASE_PATH = "custom_objects/";

        #endregion

        #region Methods

        /// <summary>
        /// Reads a custom object with a given object type ID and a value for the key attribute of the object which represents its unique identifier.
        /// </summary>
        /// <param name="key">The key attribute value of the custom object.</param>
        /// <param name="objectType">The ID of the object type.</param>
        /// <returns>A CustomObject document instance containing the custom object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="key"/> or <paramref name="objectType"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        public CustomObject GetCustomObject(string key, string objectType)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key), Properties.Resources.Error_Missing_Custom_Object_Key);
            }

            if (string.IsNullOrEmpty(objectType))
            {
                throw new ArgumentNullException(nameof(objectType), Properties.Resources.Error_Missing_Custom_Object_Type);
            }

            var customObjectUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}{objectType}/{key}";

            var headers = GetWebHeaders(customObjectUrl);

            var customObjectResponse = ServiceManager.HttpGet<CustomObject>(customObjectUrl, headers);

            return customObjectResponse;
        }

        #endregion
    }
}
