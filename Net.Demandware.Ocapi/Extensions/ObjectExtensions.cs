using System.Text;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Extensions
{
    /// <summary>
    /// Contains extension methods for any <see cref="object"/> type for use within this project.
    /// </summary>
    internal static class ObjectExtensions
    {
        #region Methods

        /// <summary>
        /// Converts an object to a JSON-serialized byte array for use as a request payload.
        /// </summary>
        /// <param name="value">An <see cref="object"/> to be serialized.</param>
        /// <returns>The serialized <see cref="object"/>.</returns>
        public static byte[] GetBytes(this object value)
        {
            var serializedValue = JsonConvert.SerializeObject(value);

            return Encoding.UTF8.GetBytes(serializedValue);
        }

        #endregion
    }
}
