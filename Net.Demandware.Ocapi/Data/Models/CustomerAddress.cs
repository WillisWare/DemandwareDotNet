using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a customer address.
    /// </summary>
    public sealed class CustomerAddress : BaseAddress
    {
        #region Properties

        /// <summary>
        /// The generated eTag representing the state of the customer address.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string ETag { get; set; }

        /// <summary>
        /// The customer address id.
        /// </summary>
        [JsonProperty(PropertyName = "address_id", Required = Required.DisallowNull)]
        [StringLength(256)]
        public string Id { get; set; }

        #endregion
    }
}
