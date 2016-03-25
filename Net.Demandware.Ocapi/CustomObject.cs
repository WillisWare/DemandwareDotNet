using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi
{
    /// <summary>
    /// Represents a custom object that contains all defined custom attributes for its object type.
    /// </summary>
    public sealed class CustomObject
    {
        #region Properties

        /// <summary>
        /// The id of the custom object when the type of the key is Integer.
        /// </summary>
        [JsonProperty(PropertyName = "key_value_integer", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntegerValue { get; set; }

        /// <summary>
        /// The name of the key property for the custom object.
        /// </summary>
        [JsonProperty(PropertyName = "key_property")]
        public string KeyProperty { get; set; }

        /// <summary>
        /// The id of the object type.
        /// </summary>
        [JsonProperty(PropertyName = "object_type")]
        [StringLength(256)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The id of the custom object when the type of the key is String.
        /// </summary>
        [JsonProperty(PropertyName = "key_value_string", NullValueHandling = NullValueHandling.Ignore)]
        public string StringValue { get; set; }

        #endregion
    }
}
