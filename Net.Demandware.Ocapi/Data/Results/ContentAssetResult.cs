using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Data.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Results
{
    /// <summary>
    /// Represents a result containing an array of content assets.
    /// </summary>
    public sealed class ContentAssetResult : BasePagedResult<ContentAsset>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<ContentAsset> Data { get; set; }

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        #endregion
    }
}
