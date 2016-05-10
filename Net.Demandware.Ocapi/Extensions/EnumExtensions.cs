using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Net.Demandware.Ocapi.Extensions
{
    /// <summary>
    /// Contains extension methods for the <see cref="Enum"/> type for use within this project.
    /// </summary>
    internal static class EnumExtensions
    {
        #region Methods

        /// <summary>
        /// Gets the customized name of an <see cref="Enum"/> value from an <see cref="EnumMemberAttribute"/>.
        /// </summary>
        /// <param name="value">An <see cref="Enum"/> value to be converted.</param>
        /// <returns>A <see cref="string"/> value containing either the <see cref="EnumMemberAttribute"/> value, the String representation of the <see cref="Enum"/>, or <see cref="string.Empty"/>.</returns>
        internal static string GetEnumMemberValue(this Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var info = value.GetType().GetField(value.ToString());
            var attributes = info.GetCustomAttributes<EnumMemberAttribute>(false);
            if (attributes.Any())
            {
                return attributes.First().Value;
            }

            return value.ToString();
        }

        #endregion
    }
}
