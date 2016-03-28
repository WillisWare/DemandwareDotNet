using System;
using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a gift certificate.
    /// </summary>
    public sealed class GiftCertificate : BaseGiftCertificate
    {
        #region Properties

        /// <summary>
        /// The gift certificate amount.
        /// </summary>
        /// <remarks>The user cannot change the gift certificate amount after the creation of the gift certificate.</remarks>
        [JsonProperty(PropertyName = "amount")]
        public Money Amount { get; set; }

        /// <summary>
        /// The gift certificate balance.
        /// </summary>
        /// <remarks>This is a computed attribute and cannot be modified.</remarks>
        [JsonProperty(PropertyName = "balance")]
        public Money Balance { get; set; }

        /// <summary>
        /// The creation date of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The URL to get the gift certificate.
        /// </summary>
        /// <remarks>This is a computed attribute and cannot be modified.</remarks>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The order number of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "order_no")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The transactions of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "transactions")]
        public IEnumerable<AccountTransaction> Transactions { get; set; }

        #endregion
    }
}
