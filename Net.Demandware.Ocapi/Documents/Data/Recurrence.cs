using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Enumerates the valid days of the week.
    /// </summary>
    public enum RecurrenceDayOfWeek
    {
        /// <summary>
        /// Indicates Monday.
        /// </summary>
        [EnumMember(Value = "monday")]
        Monday,

        /// <summary>
        /// Indicates Tuesday.
        /// </summary>
        [EnumMember(Value = "tuesday")]
        Tuesday,

        /// <summary>
        /// Indicates Wednesday.
        /// </summary>
        [EnumMember(Value = "wednesday")]
        Wednesday,

        /// <summary>
        /// Indicates Thursday.
        /// </summary>
        [EnumMember(Value = "thursday")]
        Thursday,

        /// <summary>
        /// Indicates Friday.
        /// </summary>
        [EnumMember(Value = "friday")]
        Friday,

        /// <summary>
        /// Indicates Saturday.
        /// </summary>
        [EnumMember(Value = "saturday")]
        Saturday,

        /// <summary>
        /// Indicates Sunday.
        /// </summary>
        [EnumMember(Value = "sunday")]
        Sunday
    }

    /// <summary>
    /// Represents a schedule recurrence.
    /// </summary>
    public sealed class Recurrence
    {
        #region Properties

        /// <summary>
        /// The days of week for recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "day_of_week")]
        public IEnumerable<RecurrenceDayOfWeek> DaysOfWeek { get; set; }

        /// <summary>
        /// The time of the day for recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "time_of_day")]
        public TimeOfDay TimeOfDay { get; set; }

        #endregion
    }
}
