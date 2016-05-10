using System.Collections.Generic;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents an image group containing a list of images for a particular view type and an optional variation value.
    /// </summary>
    public sealed class ImageGroup
    {
        #region Properties

        /// <summary>
        /// The images of the image group.
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IEnumerable<Image> Images { get; set; }

        /// <summary>
        /// Returns a list of variation attributes applying to this image group.
        /// </summary>
        [JsonProperty(PropertyName = "variation_attributes")]
        public IEnumerable<VariationAttribute> VariationAttributes { get; set; }

        /// <summary>
        /// The image view type.
        /// </summary>
        [JsonProperty(PropertyName = "view_type")]
        public string ViewType { get; set; }

        #endregion
    }
}
