using Net.Demandware.Ocapi.Resources.Base;

namespace Net.Demandware.Ocapi.Resources.Shop
{
    /// <summary>
    /// Contains API methods specific to gift certificates.
    /// </summary>
    /// <remarks>Uses JWT or an OAuth Business Manager user grant as authentication method.</remarks>
    public sealed class GiftCertificate : BaseResource
    {
        #region Properties

        /// <summary>
        /// Gets the base resource path.
        /// </summary>
        public override string BasePath { get; } = "gift_certificate/";

        #endregion
    }
}
