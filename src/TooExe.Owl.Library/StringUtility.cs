using System.Collections.Generic;
using System.Text;

namespace TooExe.Owl.Library
{
    public static class StringUtility
    {
        public static List<IrregularVerbForms> ListIrregularVerbForms { get; }

        static StringUtility()
        {
            var rootPath = System.AppContext.BaseDirectory;
            string path = rootPath + @"/Files/IrregularVerbForms.txt";
            ListIrregularVerbForms = new ReadWordsFromFile().GetIrregularVerbForms(path);
        }

        public static IEnumerable<string> ToWordList(this string text)
        {
            var result = new List<string>();
            if (text != null)
            {
                var endOfWord = ' ';
                var chars = text.ToCharArray();

                var sb = new StringBuilder();
                string word;

                foreach (var c in chars)
                {
                    if (c == endOfWord)
                    {
                        if ((!sb.ToString().IsBadWord()) && (sb.Length > 0))
                        {
                            word = sb.ToString().RemoveLastCharByLists();

                            if (!word.IsContainUnneceseryCharacter("\".,;:'?!"))
                            {
                                word = word.ReplaceWordToInfinitive();
                                result.Add(word);
                            }
                            sb.Clear();
                        }
                        sb.Clear();
                        continue;
                    }

                    sb.Append(c);
                }
                //if last sight isn't space
                if ((!sb.ToString().IsBadWord()) && (sb.Length > 0))
                {
                    word = sb.ToString().RemoveLastCharByLists();

                    if (!word.IsContainUnneceseryCharacter("\".,;:'?!"))
                    {
                        word = word.ReplaceWordToInfinitive();
                        result.Add(word);
                    }
                    sb.Clear();
                }
            }
            return result;
        }

        public static string ReplaceWordToInfinitive(this string text)
        {
            string result = text;

            result = result.ReplcaceRegularVerbForm();
            result = result.ReplcaceIrregularVerbForm();
            result = result.ReplacePluralWords();
            result = result.ToLower();

            return result;
        }

        public static bool IsBadWord(this string text)
        {
            var result = text.IsContainUnneceseryCharacter();
            if (result == false)
            {
                result = text.HaveTwoOrMoreUpperCaseLetter();
            }
            return result;
        }

        public static string RemoveLastCharByLists(this string text, string unnecessaryCharacters = "\".,;:'?!")
        {
            while (text[text.Length - 1].ToString().IndexOfAny(unnecessaryCharacters.ToCharArray()) != -1)
            {
                foreach (var c in unnecessaryCharacters.ToCharArray())
                {
                    if (text[text.Length - 1] == c)
                    {
                        text = text.Remove(text.Length - 1);
                    }
                }
            }
            return text;
        }

        public static string ReplcaceRegularVerbForm(this string text)
        {
            if ((text[text.Length - 1] == 'd') && (text[text.Length - 2] == 'e'))
            {
                text = text.Remove(text.Length - 2);
            }

            return text;
        }

        public static string ReplacePluralWords(this string text)
        {
            if (
                 text.EndsWith("ches") ||
                 text.EndsWith("ses") ||
                 text.EndsWith("shes") ||
                 text.EndsWith("sses") ||
                 text.EndsWith("xes")

                )
            {
                text = text.Remove(text.Length - 2);
            }
            else
            {
                if (text.EndsWith("ies"))
                {
                    text = text.Remove(text.Length - 3) + "y";
                }
                else
                {
                    if ((text.EndsWith("es")) || (text.EndsWith("ys")))
                    {
                        text = text.Remove(text.Length - 1);
                    }
                }
            }
            //TODO Exception of plural https://www.ang.pl/gramatyka/rzeczowniki-nouns/liczba-mnoga

            //TODO Create file testing for example 5 thousand words plural - singular
            return text;
        }

        public static string ReplcaceIrregularVerbForm(this string text)
        {
            foreach (var verb in ListIrregularVerbForms)
            {
                if ((text == verb.FirstForm) || (text == verb.SecondForm) || (text == verb.ThirdForm))
                {
                    return verb.FirstForm;
                }
            }

            return text;
        }

        public static bool IsContainUnneceseryCharacter(this string text, string charsCharacter = @"~`1234567890@#$%^&*()_=+{[}]\|<>/")
        {
            var result = text.IndexOfAny(charsCharacter.ToCharArray()) != -1;
            //if ((result == false) && (text.Length > 1))
            //{
            //    text = text.Remove(text.Length - 1);
            //    result = text.IndexOfAny("\".,;:'?!".ToCharArray()) != -1;
            //}

            return result;
        }

        public static bool HaveTwoOrMoreUpperCaseLetter(this string text)
        {
            int numberUpperCaseLetter = 0;

            foreach (var item in text.ToCharArray())
            {
                if ((item >= 65) && (item <= 90))
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