using System.Collections.Generic;
using Net.Demandware.Ocapi.DataTypes;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a variation attribute.
    /// </summary>
    public sealed class VariationAttribute : BaseClass
    {
        #region Properties

        /// <summary>
        /// The localized display name of the variation attribute.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public Localized<string> Name { get; set; }

        /// <summary>
        /// The sorted array of variation values. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<VariationAttributeValue> Values { get; set; }

        #endregion
    }
}
