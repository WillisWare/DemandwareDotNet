using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Data
{
    public sealed class GlobalPreferences : BaseResource
    {
        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "global_preferences/preference_groups/";

        #endregion
    }
}
