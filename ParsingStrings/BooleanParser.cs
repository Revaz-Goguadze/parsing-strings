using System;

namespace ParsingStrings
{
    public static class BooleanParser
    {
        /// <summary>
        /// Tries to convert the specified string representation of a logical value to its Boolean equivalent.
        /// </summary>
        /// <param name="str">A string containing the value to convert.</param>
        /// <param name="result">When this method returns, if the conversion succeeded, contains true if value is equal to <see cref="bool.TrueString"/> or false if value is equal to <see cref="bool.FalseString"/>. If the conversion failed, contains false.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseBoolean(string str, out bool result)
        {
            return bool.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the specified string representation of a logical value to its Boolean equivalent.
        /// </summary>
        /// <param name="str">A string containing the value to convert.</param>
        /// <returns>true if value is equivalent to <see cref="bool.TrueString"/>; false if value is equivalent to <see cref="bool.FalseString"/>.</returns>
        public static bool ParseBoolean(string str)
        {
            try
            {
                return bool.Parse(str);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
