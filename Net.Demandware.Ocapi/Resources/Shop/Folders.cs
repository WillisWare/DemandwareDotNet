using System;
using System.Linq;
using Net.Demandware.Ocapi.Documents.Common;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Exceptions;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to folders.
    /// </summary>
    /// <remarks>Does not have to authenticate the customer.</remarks>
    public sealed class Folders : BaseResource
    {
        #region Methods

        /// <summary>
        /// Returns one or more content folder.
        /// </summary>
        /// <param name="locale">The locale context.</param>
        /// <param name="levels">Specifies how many levels of nested subfolders you want the server to return. The default value is 1. Valid values are 0, 1, or 2.</param>
        /// <param name="folderIds">The IDs of the requested content folders.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="folderIds"/> is null or empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="folderIds"/> contains more than 50 items.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// This template requires you to specify one or more content folder ids and a subfolder level.
        /// In response, the server returns a result set of corresponding content folder documents.
        /// Only content folder, which are marked as online are returned.
        /// </remarks>
        public ContentFolderResult GetMultipleFolders(string locale, int levels = 1, params string[] folderIds)
        {
            if (folderIds?.Length == 0)
            {
                throw new ArgumentNullException(nameof(folderIds), Properties.Resources.Error_Missing_Folder_ID);
            }

            if (folderIds.Length > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(folderIds), Properties.Resources.Error_Folder_ID_Out_Of_Range);
            }

            var foldersUrl = $"{Configuration.ShopApiConfiguration.Url}{BasePath}({folderIds.Aggregate((source, next) => source + "," + next)})?levels={levels}&locale={locale}";

            var headers = GetWebHeaders(foldersUrl);

            var foldersResponse = ServiceManager.HttpGet<ContentFolderResult>(foldersUrl, headers);

            return foldersResponse;
        }

        /// <summary>
        /// Returns a content folder.
        /// </summary>
        /// <param name="folderId">The ID of the requested content folder.</param>
        /// <param name="locale">The locale context.</param>
        /// <param name="levels">Specifies how many levels of nested subfolders you want the server to return. The default value is 1. Valid values are 0, 1, or 2.</param>
        /// <returns>A ContentFolder document instance containing the requested folder.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="folderId"/> is null or empty.</exception>
        /// <exception cref="ApiException">Thrown when a <see cref="Fault"/> document is returned.</exception>
        /// <remarks>
        /// This template requires you to specify a content folder id and a subfolder level.
        /// In response, the server returns a corresponding content folder document.
        /// Only content folder, which are marked as online are returned.
        /// </remarks>
        public ContentFolder GetSingleFolder(string folderId, string locale, int levels = 1)
        {
            if (string.IsNullOrEmpty(folderId))
            {
                throw new ArgumentNullException(nameof(folderId), Properties.Resources.Error_Missing_Folder_ID);
            }

            var folderUrl = $"{Configuration.ShopApiConfiguration.Url}{BasePath}{folderId}?levels={levels}&locale={locale}";

            var headers = GetWebHeaders(folderUrl);

            var folderResponse = ServiceManager.HttpGet<ContentFolder>(folderUrl, headers);

            return folderResponse;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "folders/";

        #endregion
    }
}
