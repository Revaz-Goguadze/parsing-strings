using System;
using System.Globalization;

namespace ParsingStrings
{
    public static class NumberParser
    {
        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the 32-bit signed integer value equivalent of the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseInteger(string? str, out int result)
        {
            return int.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <returns>A 32-bit signed integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns zero. If an overflow error occurs returns minus one.</returns>
        public static int ParseInteger(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            try
            {
                return int.Parse(str, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its 32-bit unsigned integer equivalent. A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <param name="result">When this method returns, contains the 32-bit unsigned integer value that is equivalent to the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnsignedInteger(string str, out uint result)
        {
            // TODO #1. Implement the method using "uint.TryParse" method.
            return uint.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string representing the number to convert.</param>
        /// <returns>A 32-bit unsigned integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns minimum value of unsigned int. If an overflow error occurs returns maximum value of unsigned int.</returns>
        public static uint ParseUnsignedInteger(string? str)
        {
            // TODO #2. Implement the method using "uint.Parse" method, and add exception handling.
            try
            {
                return uint.Parse(str);
            }
            catch (FormatException)
            {
                return default;
            }
            catch (OverflowException)
            {
                return uint.MaxValue;
            }
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its Byte equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <param name="result">When this method returns, contains the Byte value equivalent to the number contained in <see cref="str"/> if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseByte(string str, out byte result)
        {
            // TODO #3. Implement the method using "byte.TryParse" method.
            return byte.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its Byte equivalent.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <returns>A byte value that is equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns maximum value of byte. If an overflow error occurs returns minimum value of byte.</returns>
        public static byte ParseByte(string? str)
        {
            // TODO #4. Implement the method using "byte.Parse" method, and add exception handling.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            try
            {
                return byte.Parse(str);
            }
            catch (FormatException)
            {
                return byte.MaxValue;
            }
            catch (OverflowException)
            {
                return byte.MinValue;
            }
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its SByte equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <param name="result">When this method returns, contains the 8-bit signed integer value that is equivalent to the number contained in <see cref="str"/> if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TrySignedByte(string str, out sbyte result)
        {
            // TODO #5. Implement the method using "sbyte.TryParse" method.
            return sbyte.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 8-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents a number to convert.</param>
        /// <returns>An 8-bit signed integer that is equivalent to the number contained in the <see cref="str"/> parameter. If a formatting error occurs returns maximum value of signed byte.</returns>
        public static sbyte ParseSignedByte(string? str)
        {
            // TODO #6. Implement the method using "sbyte.Parse" method, and add exception handling.
            try
            {
                return sbyte.Parse(str);
            }
            catch (FormatException)
            {
                return sbyte.MaxValue;
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the 16-bit signed integer value equivalent to the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseShort(string str, out short result)
        {
            // TODO #7. Implement the method using "short.TryParse" method.
            return short.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <returns>A 16-bit signed integer equivalent to the number contained in <see cref="str"/>. If an overflow error occurs returns maximum value of short.</returns>
        public static short ParseShort(string? str)
        {
            // TODO #8. Implement the method using "short.Parse" method, and add exception handling.
            try
            {
                return short.Parse(str);
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
            catch (OverflowException)
            {
                return short.MaxValue;
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <param name="result">When this method returns, contains the 16-bit unsigned integer value that is equivalent to the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnsignedShort(string str, out ushort result)
        {
            // TODO #9. Implement the method using "ushort.TryParse" method.
            return ushort.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <returns>A 16-bit unsigned integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns zero. If an overflow error occurs returns maximum value of unsigned short.</returns>
        public static ushort ParseUnsignedShort(string? str)
        {
            // TODO #10. Implement the method using "ushort.Parse" method, and add exception handling.
            try
            {
                return ushort.Parse(str);
            }
            catch (FormatException)
            {
                return default;
            }
            catch (OverflowException)
            {
                return ushort.MaxValue;
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the 64-bit signed integer value equivalent of the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed. </param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseLong(string str, out long result)
        {
            // TODO #11. Implement the method using "long.TryParse" method.
            return long.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <returns>A 64-bit signed integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns minimum value of long. If an overflow error occurs returns minus one.</returns>
        public static long ParseLong(string? str)
        {
            // TODO #12. Implement the method using "long.Parse" method, and add exception handling.
            try
            {
                return long.Parse(str);
            }
            catch (FormatException)
            {
                return long.MinValue;
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its 64-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <param name="result">When this method returns, contains the 64-bit unsigned integer value that is equivalent to the number contained in <see cref=""/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnsignedLong(string str, out ulong result)
        {
            // TODO #13. Implement the method using "ulong.TryParse" method.
            return ulong.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <returns>A 64-bit unsigned integer equivalent to the number contained in <see cref="str"/>.</returns>
        public static ulong ParseUnsignedLong(string? str)
        {
            // TODO #14. Implement the method using "ulong.Parse" method, and add exception handling if necessary.
            try
            {
                return ulong.Parse(str);
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
    }
}
