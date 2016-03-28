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
        [EnumMember(Value = "monday")]
        Monday,

        [EnumMember(Value = "tuesday")]
        Tuesday,

        [EnumMember(Value = "wednesday")]
        Wednesday,

        [EnumMember(Value = "thursday")]
        Thursday,

        [EnumMember(Value = "friday")]
        Friday,

        [EnumMember(Value = "saturday")]
        Saturday,

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
