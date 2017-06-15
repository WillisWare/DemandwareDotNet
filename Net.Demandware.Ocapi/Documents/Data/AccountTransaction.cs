using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid account transaction types.
    /// </summary>
    public enum AccountTransactionType
    {
        /// <summary>
        /// Indicates a create transaction.
        /// </summary>
        [EnumMember(Value = "create")]
        Create,

        /// <summary>
        /// Indicates a redeem transaction.
        /// </summary>
        [EnumMember(Value = "redeem")]
        Redeem,

        /// <summary>
        /// Indicates a delete transaction.
        /// </summary>
        [EnumMember(Value = "delete")]
        Delete,

        /// <summary>
        /// Indicates an enable transaction.
        /// </summary>
        [EnumMember(Value = "enable")]
        Enable,

        /// <summary>
        /// Indicates a disable transaction.
        /// </summary>
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
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = "type_code")]
        public AccountTransactionType Type { get; set; }

        #endregion
    }
}
