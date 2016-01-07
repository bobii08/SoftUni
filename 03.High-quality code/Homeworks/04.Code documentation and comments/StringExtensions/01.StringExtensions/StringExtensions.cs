using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.StringExtensions
{
    /// <summary>
    /// Contains different extensions of the string type
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the string into a hash code by a certain logic
        /// </summary>
        /// <param name="input">the string we manipulate (extend)</param>
        /// <returns>the string converted into hash code</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Checks if one of the words in the array below is present in the current string
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>boolean variable(true or false)</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] {"true", "ok", "yes", "1", "да"};
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Tries to convert a value of type string into a value of type short (tries to parse string into short)
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>in case of success: the string value converted into short; in case of fail in parsing: the default value of short i.e. 0</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Tries to convert a string into an integer
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>in case of success: the string value converted into int; in case of fail in parsing: the default value of int i.e. 0</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Tries to convert a string into an integer number of type long
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>in case of success: the string value converted into long; in case of fail in parsing: the default value of long i.e. 0</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Tries to convert a string value into a value of time DateTime
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>in case of fail in parsing: the default value of DateTime i.e. 01-Jan-01 12:00:00 AM</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Tries to make the first letter of a string capital
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>if the string we check is null or empty: the string we are checking; if the string is not null or empty: capitalizes the first letter of the string</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return
                input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
                input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Gets the string between two separate strings in the string value we check
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <param name="startString">the first string that is supposed to be a part of the string we check</param>
        /// <param name="endString">the seconds string that is supposed to be a part of the string we check</param>
        /// <param name="startFrom">the start position from which we began to search the first string</param>
        /// <returns>the string between the two strings we give to the method; in case of fail: string.Empty</returns>
        public static string GetStringBetween(
            this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition =
                input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts cyrillic letters to latin letters
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>the converted string which consists of latin letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
            {
                "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
                "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
            };
            var latinRepresentationsOfBulgarianLetters = new[]
            {
                "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
            };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(),
                    latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts latin letters to cyrillic letters according to the keyboard
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>the string converted into cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            var bulgarianRepresentationOfLatinKeyboard = new[]
            {
                "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                "в", "ь", "ъ", "з"
            };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(),
                    bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Changes the cyrillic letters with latin letters and converts the string into a valid user name according to a certain logic. The logic simply removes characters different than all latin letters, all numbers and the "_" and "." symbols
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>the string converted into a valid user name</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Changes the cyrillic letters with latin letters and the single whitespaces with the "-" symbol. Converts the string into a valid file name written with latin letters
        /// </summary>
        /// <param name="input">the string we check</param>
        /// <returns>the string converted into a valid latin file name</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets the first characters of the string
        /// </summary>
        /// <param name="input">the string we manipulate</param>
        /// <param name="charsCount">the number of characters we want to get from the beginning of the string</param>
        /// <returns>a substring from the string we manipulate or the whole string in case the charsCount argument is less than the length of the string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets the extesion of the file name
        /// </summary>
        /// <param name="fileName">the string we manipulate</param>
        /// <returns>in case of success: the string after the last "." symbol; in case of fail: string.Empty</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] {"."}, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Converts a file extesion into content type
        /// </summary>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
            {
                {"jpg", "image/jpeg"},
                {"jpeg", "image/jpeg"},
                {"png", "image/x-png"},
                {"docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
                {"doc", "application/msword"},
                {"pdf", "application/pdf"},
                {"txt", "text/plain"},
                {"rtf", "application/rtf"}
            };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts the string into an array of bytes
        /// </summary>
        /// <param name="input">hte string we convert</param>
        /// <returns>an array of bytes</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length*sizeof (char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}