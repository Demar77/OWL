using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TooExe.Owl.Library
{
    public static class StringUtility
    {
        public static IEnumerable<string> ToWordList(this string text, char[] charsCharacter  )
        {
            var endOfWord = ' ';
            var chars = text.ToCharArray();
            var result = new List<string>();
            var sb = new StringBuilder();

            foreach (var c in chars)
            {
                if (c == endOfWord)
                {
                    if ((sb.Length > 0))
                    {
                        result.Add(sb.ToString());
                        sb.Clear();
                    }
                    sb.Clear();
                    continue;
                }

                foreach (var item in )
                {

                }
                    sb.Append(c);
                

            }
            //if last sight isn't space
            if ((!sb.ToString().IsCorrectWord()) && (sb.Length > 0))
            {
                result.Add(sb.ToString());
                sb.Clear();
            }
            return result;

        }
        
        //http://stackoverflow.com/questions/1390749/check-if-a-string-contains-one-of-10-characters
        public static bool IsCorrectWord(this string text)
        {
            var match = text.IsContainUnneceseryCharacter();
            if (match == false)
            {
                match = text.HaveTwoOrMoreUpperCaseLetter();
            }
            return match;
        }

        public static bool IsCharacterDontAdd(this char charCharacter, string unnecessaryCharacters = @".,;:")
        {
            foreach (var c in unnecessaryCharacters.ToCharArray())
            {
                if (charCharacter == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsContainUnneceseryCharacter(this string text, string charsCharacter = @"0123456789!@#$%^&*(){}[]'/")
        {
            var match = text.IndexOfAny(charsCharacter.ToCharArray()) != -1;

            return match;
        }

        public static bool HaveTwoOrMoreUpperCaseLetter(this string text)
        {
            int numberUpperCaseLetter = 0;

            foreach (var item in text.ToCharArray())
            {
                if (((int)item >= 65) && ((int)item <= 90))
                {
                    numberUpperCaseLetter++;
                }
                if (numberUpperCaseLetter > 1)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
