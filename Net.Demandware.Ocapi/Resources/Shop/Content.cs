using System;
using System.Linq;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to content.
    /// </summary>
    /// <remarks>Does not have to authenticate the customer.</remarks>
    public sealed class Content : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the content API for URL-building.
        /// </summary>
        private const string BASE_PATH = "content/";

        #endregion

        #region Methods

        /// <summary>
        /// Returns multiple content assets.
        /// </summary>
        /// <param name="locale">The locale context.</param>
        /// <param name="contentIds">The IDs of the requested content assets.</param>
        /// <returns>A ContentResult document instance containing the content assets.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="contentIds"/> is null or empty.</exception>
        /// <remarks>This template requires you to specify one or many content asset id. In response, the server returns a result set of corresponding content asset documents. Only content assets, which are marked as online are returned. An assignment to a folder is not necessary.</remarks>
        public ContentResult GetMultipleContentAssets(string locale, params string[] contentIds)
        {
            if (contentIds?.Length == 0)
            {
                throw new ArgumentNullException(nameof(contentIds), Properties.Resources.Error_Missing_Content_ID);
            }

            var contentUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}({contentIds.Aggregate((source, next) => source + "," + next)})?locale={locale}";

            var headers = GetWebHeaders(contentUrl);

            var contentResponse = ServiceManager.HttpGet<ContentResult>(contentUrl, headers);

            return contentResponse;
        }

        /// <summary>
        /// Returns a single content asset identified by its ID.
        /// </summary>
        /// <param name="contentId">The ID of the requested content asset.</param>
        /// <param name="locale">The locale context.</param>
        /// <returns>A Content document instance containing the requested content asset.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="contentId"/> is null or empty.</exception>
        /// <remarks>This template requires you to specify a content asset id. In response, the server returns a corresponding content asset document. Only content assets, which are marked as online are returned. An assignment to a folder is not necessary.</remarks>
        public Documents.Shop.Content GetSingleContentAsset(string contentId, string locale)
        {
            if (string.IsNullOrEmpty(contentId))
            {
                throw new ArgumentNullException(nameof(contentId), Properties.Resources.Error_Missing_Content_ID);
            }

            var contentUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}{contentId}?locale={locale}";

            var headers = GetWebHeaders(contentUrl);

            var contentResponse = ServiceManager.HttpGet<Documents.Shop.Content>(contentUrl, headers);

            return contentResponse;
        }

        #endregion
    }
}
