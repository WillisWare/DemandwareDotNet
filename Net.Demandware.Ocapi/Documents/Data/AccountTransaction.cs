using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid account transaction types.
    /// </summary>
    public enum AccountTransactionType
    {
        [EnumMember(Value = "create")]
        Create,

        [EnumMember(Value = "redeem")]
        Redeem,

        [EnumMember(Value = "delete")]
        Delete,

        [EnumMember(Value = "enable")]
        Enable,

        [EnumMember(Value = "disable")]
        Disable
    }

    /// <summary>
    /// Represents an account transaction.
    /// </summary>
    public sealed class AccountTransaction
    {
        #region Properties

        /// <summary>
        /// The amount of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public Money Amount { get; set; }

        /// <summary>
        /// The order number of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "order_no")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The timestamp of the transaction of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The type code of the gift certificate.
        /// </summary>
        [JsonProperty(PropertyName = "type_code")]
        public AccountTransactionType Type { get; set; }

        #endregion
    }
}
