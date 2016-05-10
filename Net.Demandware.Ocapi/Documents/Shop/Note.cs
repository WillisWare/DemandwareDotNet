using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a note.
    /// </summary>
    public sealed class Note
    {
        #region Properties

        /// <summary>
        /// The author of the note.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The creation date of the note.
        /// </summary>
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The note's subject.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        [StringLength(256)]
        public string Subject { get; set; }

        /// <summary>
        /// The note's text.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        #endregion
    }
}
