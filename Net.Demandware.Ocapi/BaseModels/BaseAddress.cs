using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    /// <summary>
    /// Represents the basic structure of an address.
    /// </summary>
    public abstract class BaseAddress
    {
        #region Properties

        /// <summary>
        /// The first address.
        /// </summary>
        [JsonProperty(PropertyName = "address1")]
        [StringLength(256)]
        public string Address1 { get; set; }

        /// <summary>
        /// The second address.
        /// </summary>
        [JsonProperty(PropertyName = "address2")]
        [StringLength(256)]
        public string Address2 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        [StringLength(256)]
        public string City { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [JsonProperty(PropertyName = "company_name")]
        [StringLength(256)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-1 (Alpha-2) country code.
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        [StringLength(2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        [StringLength(256)]
        public string FirstName { get; set; }

        /// <summary>
        /// The full name.
        /// </summary>
        [JsonProperty(PropertyName = "full_name")]
        [StringLength(256)]
        public string FullName { get; set; }

        /// <summary>
        /// The job title.
        /// </summary>
        [JsonProperty(PropertyName = "job_title")]
        [StringLength(256)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        [StringLength(256)]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        [StringLength(32)]
        public string Phone { get; set; }

        /// <summary>
        /// The post box.
        /// </summary>
        [JsonProperty(PropertyName = "post_box")]
        [StringLength(256)]
        public string PostOfficeBox { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        [JsonProperty(PropertyName = "postal_code")]
        [StringLength(256)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The salutation.
        /// </summary>
        [JsonProperty(PropertyName = "salutation")]
        [StringLength(256)]
        public string Salutation { get; set; }

        /// <summary>
        /// The second name.
        /// </summary>
        [JsonProperty(PropertyName = "second_name")]
        [StringLength(256)]
        public string SecondName { get; set; }

        /// <summary>
        /// The state code.
        /// </summary>
        [JsonProperty(PropertyName = "state_code")]
        [StringLength(256)]
        public string StateCode { get; set; }

        /// <summary>
        /// The suffix.
        /// </summary>
        [JsonProperty(PropertyName = "suffix")]
        [StringLength(256)]
        public string Suffix { get; set; }

        /// <summary>
        /// The suite.
        /// </summary>
        [JsonProperty(PropertyName = "suite")]
        [StringLength(32)]
        public string Suite { get; set; }

        /// <summary>
        /// The title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        [StringLength(256)]
        public string Title { get; set; }

        #endregion
    }
}
