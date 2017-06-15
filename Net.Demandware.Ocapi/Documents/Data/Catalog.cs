using System;
using System.Collections.Generic;
using Net.Demandware.Ocapi.DataTypes;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Document representing a catalog.
    /// </summary>
    public sealed class Catalog : BaseClass
    {
        #region Properties

        /// <summary>
        /// The count of products assigned to the catalog.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "assigned_product_count")]
        public int AssignedProductCount { get; private set; }

        /// <summary>
        /// The sites assigned to the catalog.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "assigned_sites")]
        public IEnumerable<Site> AssignedSites { get; private set; } = new List<Site>();

        /// <summary>
        /// The category count of catalog.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "category_count")]
        public int CategoryCount { get; private set; }

        /// <summary>
        /// Returns the value of attribute 'creationDate'.
        /// </summary>
        [JsonProperty(PropertyName = "creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The description of catalog.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public Localized<string> Description { get; set; }

        /// <summary>
        /// The online status of catalog.
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// URL that is used to get this instance.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; private set; }

        /// <summary>
        /// Returns the value of attribute 'lastModified'.
        /// </summary>
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The catalog name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public Localized<string> Name { get; set; }

        /// <summary>
        /// The count of products owned by the catalog.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "owned_product_count")]
        public int OwnedProductCount { get; private set; }

        /// <summary>
        /// The recommendation count of the catalog.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "recommendation_count")]
        public int RecommendationCount { get; private set; }

        /// <summary>
        /// The root category of the catalog.
        /// </summary>
        /// <remarks>It is read only.</remarks>
        [JsonProperty(PropertyName = "root_category")]
        public string RootCategory { get; private set; }

        #endregion
    }
}
