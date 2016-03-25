using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a time schedule within a single day.
    /// </summary>
    public sealed class TimeOfDay
    {
        // TODO: Figure out if DW LocalTime translates to String or if it will fit into a DateTime.
        #region Properties

        /// <summary>
        /// The time to start from.
        /// </summary>
        /// <remarks>Time format: HH:mm:ss. Seconds are ignored and set to 0.</remarks>
        [JsonProperty(PropertyName = "time_from")]
        public string From { get; set; }

        /// <summary>
        /// The time to end on.
        /// </summary>
        /// <remarks>Time format: HH:mm:ss. Seconds are ignored and set to 0.</remarks>
        [JsonProperty(PropertyName = "time_to")]
        public string To { get; set; }

        #endregion
    }
}
