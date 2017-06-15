using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    public sealed class Site : BaseResource
    {
        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "site/";

        #endregion
    }
}
