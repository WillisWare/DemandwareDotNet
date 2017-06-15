using System.Collections.Generic;

namespace Net.Demandware.Ocapi.DataTypes
{
    /// <summary>
    /// Represents a localized (or localizable) value as a property of an OCAPI model.
    /// </summary>
    /// <typeparam name="T">The <see cref="System.Type"/> of the localized value.</typeparam>
    public sealed class Localized<T> : Dictionary<string, T>
    {
        #region Methods

        /// <summary>
        /// Adds the specified <see cref="KeyValuePair{TKey,TValue}"/> to the dictionary.
        /// </summary>
        /// <param name="value">The element to add.</param>
        public void Add(KeyValuePair<string, T> value)
        {
            Add(value.Key, value.Value);
        }

        #endregion
    }
}
