using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    public sealed class CustomerInfo : BaseClass
    {
        #region Properties

        [JsonProperty(PropertyName = "customer_id")]
        public override string Id { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "customer_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "customer_no")]
        public string Number { get; set; }

        #endregion
    }
}
