using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Document representing a status of an object.
    /// </summary>
    public sealed class Status
    {
        #region Properties

        /// <summary>
        /// The status code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The status message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The status.
        /// </summary>
        /// <remarks>For more information on the status values see dw.system.Status.OK and dw.system.Status.ERROR.</remarks>
        [JsonProperty(PropertyName = "status")]
        public int StatusCode { get; set; }

        #endregion
    }
}
