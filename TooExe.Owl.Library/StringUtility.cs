using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TooExe.Owl.Library
{
    public static class StringUtility
    {
        public static IEnumerable<string> ToWordList(this string text)
        {
            var endOfWord = ' ';
            var chars = text.ToCharArray();
            var result = new List<string>();
            var sb = new StringBuilder();
            var isNewWord = false;
            foreach (var c in chars)
            {
                if (c == endOfWord)
                {
                    if (sb.Length > 0)
                    {
                        result.Add(sb.ToString());
                        sb.Clear();
                    }
                    isNewWord = true;
                    continue;
                }

                sb.Append(c);
            }
            //if last sight isn't space
            if (sb.Length > 0)
            {
                result.Add(sb.ToString());
                sb.Clear();
            }
            return result;

        }
    }
}
