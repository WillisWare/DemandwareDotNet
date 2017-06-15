using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Data
{
    public sealed class CodeVersions : BaseResource
    {
        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "code_versions/";

        #endregion
    }
}
