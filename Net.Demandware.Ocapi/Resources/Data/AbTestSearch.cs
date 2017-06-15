using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Data
{
    public sealed class AbTestSearch : BaseResource
    {
        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "sites/{site_id}/ab_test_search/";

        #endregion
    }
}
