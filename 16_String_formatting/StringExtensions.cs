using System;

namespace StringFormattingSpecial
{
	public static class ExtensionMethods
    {
        /// <summary>
        /// Shortens string to Max length
        /// </summary>
        public static string MaxLength(this string input, int length)
        {
            if (input == null) return null;
            return input.Substring(0, Math.Min(length, input.Length));
        }
    }
}
