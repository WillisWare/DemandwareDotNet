using System;
using Net.Demandware.Ocapi.Documents.Shop;
using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to content searches.
    /// </summary>
    /// <remarks>Does not have to authenticate the customer.</remarks>
    public sealed class ContentSearch : BaseResource
    {
        #region Members

        /// <summary>
        /// Defines the base path of the content search API for URL-building.
        /// </summary>
        private const string BASE_PATH = "content_search";

        #endregion

        #region Methods

        /// <summary>
        /// Provides keyword and refinement search functionality for content assets.
        /// </summary>
        /// <param name="query">The query phrase to search for.</param>
        /// <param name="locale">The locale context.</param>
        /// <param name="refine">
        /// Parameter that represents a refinement attribute/value(s) pair.
        /// <para>
        /// Refinement attribute id and value(s) are separated by '='. Multiple values are supported by a sub-set of refinement attributes and can be provided by separating them using a pipe (URL encoded = "|"). Value ranges can be specified like this: refine=foo=(100..500) Multiple refine parameters can be provided by adding an underscore in combination with an integer counter right behind the parameter name and a counter range 1..9. I.e. refine_1=c_refinementType=type1|type2|type3. The following system refinement attribute ids are supported:
        /// <list type="bullet">
        /// <item><term>fdid</term><description>Allows to refine per single content folder id. Multiple folder ids are not supported.</description></item>
        /// </list>
        /// </para>
        /// </param>
        /// <param name="sort">
        /// Parameter that represents a sorting attribute/value(s) pair.
        /// <para>
        /// Sorting attribute id and value are separated by '='. The value describes the sort direction. Possible values are 'asc' and 'desc', for ascending or descending sort direction. I.e. sort=c_myAttribute=desc. Precondition: You have to select your sorting attributes in Business Manager &gt; YourSite &gt; Search Indexes &gt; Content Index &gt; Sorting Attributes.
        /// </para>
        /// </param>
        /// <param name="start">The result set index to return the first instance for.</param>
        /// <param name="count">The maximum number of instances per request.</param>
        /// <returns>A ContentSearchResult document instance containing the content assets.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="query"/> length is greater than 50.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="query"/> is null or empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is less than one or greater than 200.</exception>
        /// <remarks>The search result contains only content that is online and assigned to a folder.</remarks>
        public ContentSearchResult SearchContent(string query, string locale, string refine = null, string sort = null, int start = 0, int count = 25)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException(nameof(query), Properties.Resources.Error_Missing_Query_String);
            }

            if (query.Length > 50)
            {
                throw new ArgumentException(Properties.Resources.Error_Query_String_Length, nameof(query));
            }

            if (count < 1 || count > 200)
            {
                throw new ArgumentOutOfRangeException(nameof(count), Properties.Resources.Error_Query_Count_Out_Of_Range);
            }

            var contentSearchUrl = $"{Configuration.ShopApiConfiguration.Url}{BASE_PATH}?q={query}&locale={locale}&refine={refine}&sort={sort}&start={start}&count={count}";

            var headers = GetWebHeaders(contentSearchUrl);

            var contentSearchResponse = ServiceManager.HttpGet<ContentSearchResult>(contentSearchUrl, headers);

            return contentSearchResponse;
        }

        #endregion
    }
}
