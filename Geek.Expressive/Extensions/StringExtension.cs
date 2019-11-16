using System;

namespace Geek.Expressive.Extensions
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNull(this string value)
        {
            return value == null;
        }

        public static void MustNotBeNullOrEmpty(this string value, string paramaterName)
        {
            if (value.IsNullOrEmpty())
                throw new ArgumentException($"{paramaterName} cannot be null or empty");
        }

        public static void MustNotBeNullOrWhitespace(this string value, string paramaterName)
        {
            if (value.IsNullOrWhiteSpace())
                throw new ArgumentException($"{paramaterName} cannot be null or blank");
        }

        public static bool EqualsWithoutCase(this string value, string valueToCompare)
        {
            return value.Equals(valueToCompare, StringComparison.CurrentCultureIgnoreCase);
        }


    }
}
