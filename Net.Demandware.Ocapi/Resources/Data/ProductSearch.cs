using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Data
{
    public sealed class ProductSearch : BaseResource
    {
        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "product_search/";

        #endregion
    }
}
