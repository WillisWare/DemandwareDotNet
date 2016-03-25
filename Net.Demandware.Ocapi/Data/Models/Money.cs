using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents money for a transaction.
    /// </summary>
    public sealed class Money
    {
        #region Properties

        /// <summary>
        /// The mnemonic for the money.
        /// </summary>
        [JsonProperty(PropertyName = "currency_mnemonic")]
        public string CurrencyMnemonic { get; set; }

        /// <summary>
        /// The value for the money.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        #endregion
    }
}
