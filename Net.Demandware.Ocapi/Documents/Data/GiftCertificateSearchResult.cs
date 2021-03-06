﻿using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a result containing an array of gift certificates.
    /// </summary>
    public sealed class GiftCertificateSearchResult : BasePagedResult<GiftCertificate>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<GiftCertificate> Data { get; set; }

        /// <summary>
        /// The filter to apply to narrow down the results.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public Filter Filters { get; set; }

        /// <summary>
        /// The query passed into the search.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public Query Query { get; set; }

        /// <summary>
        /// The list of sort clauses configured for the search request.
        /// </summary>
        /// <remarks>Sort clauses are optional.</remarks>
        [JsonProperty(PropertyName = "sorts")]
        public IEnumerable<Sort> Sorts { get; set; }

        #endregion
    }
}
