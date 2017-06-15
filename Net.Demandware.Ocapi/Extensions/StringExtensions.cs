using System;
using System.Text;

namespace Net.Demandware.Ocapi.Extensions
{
    /// <summary>
    /// Contains extension methods for the <see cref="string"/> type for use within this project.
    /// </summary>
    internal static class StringExtensions
    {
        #region Methods

        /// <summary>
        /// Encodes a string value to base 64.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value to be encoded.</param>
        /// <returns>A <see cref="string"/> value containing the original value, encoded to base 64.</returns>
        public static string EncodeTo64(this string value)
        {
            var toEncodeAsBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(toEncodeAsBytes);
        }

        /// <summary>
        /// Converts a string value to a UTF-8 encoded byte array.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value to be converted.</param>
        /// <returns>An array of <see cref="byte"/> representing the specified value.</returns>
        public static byte[] GetBytes(this string value)
        {
            return Encoding.UTF8.GetBytes(value);
        }

        /// <summary>
        /// Prefixes a string with a specified value if the string is not null or empty.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value to evaluate for null or empty.</param>
        /// <param name="prefix">A <see cref="string"/> value containing the prefix to be added.</param>
        /// <returns>A <see cref="string"/> value containing the original value prepended with the specified prefix if not null; otherwise, <seealso cref="string.Empty"/>.</returns>
        public static string PrependIfNotNullOrEmpty(this string value, string prefix)
        {
            return (string.IsNullOrEmpty(value) ? string.Empty : $"{prefix}{value}");
        }

        #endregion
    }
}
