using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Exceptions
{
    public sealed class DemandwareException
    {
        #region Properties

        [JsonProperty("fault")]
        public Fault Fault { get; set; }

        [JsonProperty("_v")]
        public string Version { get; set; }

        #endregion
    }
}
