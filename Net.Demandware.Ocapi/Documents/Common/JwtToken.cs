using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Common
{
    public sealed class JwtToken
    {
        #region Properties

        [JsonProperty(PropertyName = "auth_type")]
        public string AuthorizationType { get; set; }

        [JsonProperty(PropertyName = "customer_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "preferred_locale")]
        public string Locale { get; set; }

        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "_v")]
        public string Version { get; set; }

        #endregion
    }
}
