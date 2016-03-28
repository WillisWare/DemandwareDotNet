using System;
using System.Text;

namespace Net.Demandware.Ocapi.Extensions
{
    /// <summary>
    /// Contains extension methods for the String type for use within this project.
    /// </summary>
    internal static class StringExtensions
    {
        #region Methods

        /// <summary>
        /// Encodes a string value to base 64.
        /// </summary>
        /// <param name="value">The String value to be encoded.</param>
        /// <returns>A String value containing the original value, encoded to base 64.</returns>
        public static string EncodeTo64(this string value)
        {
            var toEncodeAsBytes = Encoding.ASCII.GetBytes(value);
            return Convert.ToBase64String(toEncodeAsBytes);
        }

        /// <summary>
        /// Prefixes a string with a specified value if the string is not null or empty.
        /// </summary>
        /// <param name="value">The String value to evaluate for null or empty.</param>
        /// <param name="prefix">A String value containing the prefix to be added.</param>
        /// <returns>A String value containing the original value prepended with the specified prefix if not null; otherwise, an empty String.</returns>
        public static string PrependIfNotNullOrEmpty(this string value, string prefix)
        {
            return (string.IsNullOrEmpty(value) ? string.Empty : $"{prefix}{value}");
        }

        #endregion
    }
}
