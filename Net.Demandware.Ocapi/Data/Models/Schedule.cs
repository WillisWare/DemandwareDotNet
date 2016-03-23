using System;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a time schedule for slots.
    /// </summary>
    public sealed class Schedule
    {
        #region Properties

        /// <summary>
        /// The date to end of validity.
        /// </summary>
        /// <remarks>ISO8601 date time format: yyyy-MM-ddTHH:mm:ss:mmmZ.</remarks>
        [JsonProperty(PropertyName = "end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The recurrence of the schedule by day of week and time of day.
        /// </summary>
        /// <remarks>Not all schedules will support a recurrence.</remarks>
        [JsonProperty(PropertyName = "recurrence")]
        public Recurrence Recurrence { get; set; }

        /// <summary>
        /// The date to start validity.
        /// </summary>
        /// <remarks>ISO8601 date time format: yyyy-MM-ddTHH:mm:ss:mmmZ.</remarks>
        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }

        #endregion
    }
}
