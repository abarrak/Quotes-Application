using System;
using System.Text.RegularExpressions;

namespace QuotesApp.Domain.Utils
{
    public static class StringExtensions
    {
        public static string RemoveAllWhitespace(this string text)
        {
            return Regex.Replace(text, @"\s+", "");
        }
    }
}
