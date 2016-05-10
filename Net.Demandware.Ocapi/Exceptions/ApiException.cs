using System;
using Net.Demandware.Ocapi.Documents.Common;

namespace Net.Demandware.Ocapi.Exceptions
{
    /// <summary>
    /// Represents an exception encountered during an API call that results in a Fault document response.
    /// </summary>
    public sealed class ApiException : Exception
    {
        #region Constructors

        /// <summary>
        /// Overloaded constructor. Initializes an instance of this class with the specified Fault document.
        /// </summary>
        /// <param name="fault">A Fault document instance to be assigned to this exception.</param>
        public ApiException(Fault fault) : base(fault.Message)
        {
            Fault = fault;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the fault document associated with this exception.
        /// </summary>
        public Fault Fault { get; set; }

        #endregion
    }
}
