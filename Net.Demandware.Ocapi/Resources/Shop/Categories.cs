using System;
using System.Linq;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Exceptions;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to categories.
    /// </summary>
    /// <remarks>Does not have to authenticate the customer.</remarks>
    public sealed class Categories : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the categories API for URL-building.
        /// </summary>
        private const string BASE_PATH = "categories/";

        #endregion

        #region Methods

        /// <summary>
        /// Returns multiple categories.
        /// </summary>
        /// <param name="levels">Specifies how many levels of nested subcategories you want the server to return. The default value is 1. Valid values are 0, 1, or 2.</param>
        /// <param name="locale">The locale context.</param>
        /// <param name="categoryIds">The list of category IDs.</param>
        /// <returns>A CategoryResult document instance containing the categories.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="categoryIds"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// You can use this template as a convenient way of obtaining multiple categories in a single request, instead of issuing separate requests for each category.
        /// You can specify multiple ids (up to a maximum of 50). You must enclose the list of ids in parentheses.
        /// If a category identifier contains a parenthesis or the separator sign, you must URL encode the character.
        /// The server only returns online categories.
        /// </remarks>
        public CategoryResult GetMultipleCategories(string locale, int levels = 1, params string[] categoryIds)
        {
            if (categoryIds?.Length == 0)
            {
                throw new ArgumentNullException(nameof(categoryIds), Properties.Resources.Error_Missing_Category_ID);
            }

            var categoriesUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}({categoryIds.Aggregate((source, next) => source + "," + next)})?levels={levels}&locale={locale}";

            var headers = GetWebHeaders(categoriesUrl);

            var categoriesResponse = ServiceManager.HttpGet<CategoryResult>(categoriesUrl, headers);

            return categoriesResponse;
        }

        /// <summary>
        /// Returns a single category identified by its ID.
        /// </summary>
        /// <param name="categoryId">The ID of the requested category.</param>
        /// <param name="locale">The locale context.</param>
        /// <param name="levels">Specifies how many levels of nested subcategories you want the server to return. The default value is 1. Valid values are 0, 1, or 2.</param>
        /// <returns>A Category document instance containing the requested category.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="categoryId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>By default, the server also returns the first level of subcategories, but you can specify another level by setting the levels parameter. The server only returns online categories.</remarks>
        public Category GetSingleCategory(string categoryId, string locale, int levels = 1)
        {
            if (string.IsNullOrEmpty(categoryId))
            {
                throw new ArgumentNullException(nameof(categoryId), Properties.Resources.Error_Missing_Category_ID);
            }

            var categoryUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}{categoryId}?levels={levels}&locale={locale}";

            var headers = GetWebHeaders(categoryUrl);

            var categoryResponse = ServiceManager.HttpGet<Category>(categoryUrl, headers);

            return categoryResponse;
        }

        #endregion
    }
}
