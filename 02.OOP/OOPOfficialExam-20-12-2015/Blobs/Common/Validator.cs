namespace Blobs.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfStringIsNullOrWhitespace(string str, string paramName)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(paramName, string.Format("{0} cannot be null or whitespace.", paramName));
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string str, string paramName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(paramName, string.Format("{0} cannot be null or empty.", paramName));
            }
        }

        public static void CheckIfIntNumberIsNegative(int number, string paramName)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, string.Format("{0} must be non-negative", paramName));
            }
        }
        
        public static void CheckIfIntNumberIsNonPositive(int number, string paramName)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName, string.Format("{0} must be positve", paramName));
            }
        }
    }
}
