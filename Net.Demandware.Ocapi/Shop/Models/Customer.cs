using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop.Models
{
    /// <summary>
    /// Enumerates the valid authorization types for a customer.
    /// </summary>
    public enum CustomerAuthType
    {
        [EnumMember(Value = "guest")]
        Guest,

        [EnumMember(Value = "registered")]
        Registered
    }

    /// <summary>
    /// Represents a customer.
    /// </summary>
    public sealed class Customer : BaseClass
    {
        #region Properties

        /// <summary>
        /// The customer's addresses.
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public IEnumerable<CustomerAddress> Addresses { get; set; }

        /// <summary>
        /// The customer's authorization type (indicates if the customer is a guest or a registered customer).
        /// </summary>
        [JsonProperty(PropertyName = "auth_type")]
        public CustomerAuthType AuthType { get; set; }

        /// <summary>
        /// The customer's birthday.
        /// </summary>
        [JsonProperty(PropertyName = "birthday")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The customer's business phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone_business")]
        [StringLength(32)]
        public string BusinessPhone { get; set; }

        /// <summary>
        /// The customer's company name.
        /// </summary>
        [JsonProperty(PropertyName = "company_name")]
        [StringLength(256)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The customer's creation date.
        /// </summary>
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        [StringLength(256)]
        public string Email { get; set; }

        /// <summary>
        /// The customer's fax number.
        /// </summary>
        /// <remarks>The length is restricted to 32 characters.</remarks>
        [JsonProperty(PropertyName = "fax")]
        [StringLength(32)]
        public string Fax { get; set; }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        [StringLength(256)]
        public string FirstName { get; set; }

        /// <summary>
        /// The customer's gender.
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public int Gender { get; set; }

        /// <summary>
        /// The customer's home phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone_home")]
        [StringLength(32)]
        public string HomePhone { get; set; }

        /// <summary>
        /// The customer's number (id). Both registered and guest customers have a customer id.
        /// </summary>
        [JsonProperty(PropertyName = "customer_id")]
        [StringLength(28)]
        public override string Id { get; set; }

        /// <summary>
        /// A flag indicating whether this customer is enabled and can log in.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The customer's job title.
        /// </summary>
        [JsonProperty(PropertyName = "job_title")]
        [StringLength(256)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The time when the customer last logged in.
        /// </summary>
        [JsonProperty(PropertyName = "last_login_time")]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        [StringLength(256)]
        public string LastName { get; set; }

        /// <summary>
        /// The time when the customer last visited.
        /// </summary>
        [JsonProperty(PropertyName = "last_visit_time")]
        public DateTime LastVisit { get; set; }

        /// <summary>
        /// The customer's login.
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        [StringLength(256)]
        public string Login { get; set; }

        /// <summary>
        /// The customer's mobile phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone_mobile")]
        [StringLength(32)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The customer's number (id).
        /// </summary>
        /// <remarks>Only a registered customer has a customer number.</remarks>
        [JsonProperty(PropertyName = "customer_no")]
        [StringLength(100)]
        public string Number { get; set; }

        /// <summary>
        /// The customer's payment instruments.
        /// </summary>
        [JsonProperty(PropertyName = "payment_instruments")]
        public IEnumerable<CustomerPaymentInstrument> PaymentInstruments { get; set; }

        /// <summary>
        /// The customer's preferred locale.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_locale")]
        public string PreferredLocale { get; set; }

        /// <summary>
        /// The time when the customer logged in previously.
        /// </summary>
        [JsonProperty(PropertyName = "previous_login_time")]
        public DateTime PreviousLogin { get; set; }

        /// <summary>
        /// The time when the customer last visited the store.
        /// </summary>
        [JsonProperty(PropertyName = "previous_visit_time")]
        public DateTime PreviousVisit { get; set; }

        /// <summary>
        /// The salutation to use for the customer.
        /// </summary>
        [JsonProperty(PropertyName = "salutation")]
        [StringLength(256)]
        public string Salutation { get; set; }

        /// <summary>
        /// The customer's second name.
        /// </summary>
        [JsonProperty(PropertyName = "second_name")]
        [StringLength(256)]
        public string SecondName { get; set; }

        /// <summary>
        /// The customer's suffix (for example, "Jr." or "Sr.").
        /// </summary>
        [JsonProperty(PropertyName = "suffix")]
        [StringLength(256)]
        public string Suffix { get; set; }

        /// <summary>
        /// The customer's title (for example, "Mrs" or "Mr").
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        [StringLength(256)]
        public string Title { get; set; }

        #endregion
    }
}
