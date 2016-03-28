using Net.Demandware.Ocapi.Resources.Common;

namespace Net.Demandware.Ocapi.Resources.Base
{
    /// <summary>
    /// Contains the core functionality of a resource (service) class.
    /// </summary>
    public abstract class BaseResource
    {
        #region Members

        #endregion

        #region Methods

        #endregion

        #region Properties

        /// <summary>
        /// Gets a singleton instance of ServiceManager for performing API calls.
        /// </summary>
        protected ServiceManager ServiceManager { get; } = ServiceManager.GetInstance();

        #endregion
    }
}
