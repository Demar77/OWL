﻿using System.Collections.Generic;
using System.Text;

namespace TooExe.Owl.Library
{
    public static class StringUtility
    {
        public static IEnumerable<string> ToWordList(this string text )
        {
            var endOfWord = ' ';
            var chars = text.ToCharArray();
            var result = new List<string>();
            var sb = new StringBuilder();
            string word;

            foreach (var c in chars)
            {
                if (c == endOfWord)
                {
                    if ((!sb.ToString().IsBadWord()) &&(sb.Length > 0))
                    {
                        word = sb.ToString();
                        word = word.RemoveLastCharByLists();
                        word = word.ReplcaceRegularVerbForm();
                       // word = word.ReplcaceIrregularVerbForm();
                        //TODO Example Paris - in this version 
                        word = word.ToLower();
                        result.Add(word);
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
                word = sb.ToString();
                word = word.RemoveLastCharByLists();
                word = word.ReplcaceRegularVerbForm();
                //TODO Example Paris - in this version 
                word = word.ToLower();

                result.Add(word);
                sb.Clear();
            }
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

        public static string RemoveLastCharByLists(this string text, string unnecessaryCharacters = "\".,;:'?")
        {
           
            foreach (var c in unnecessaryCharacters.ToCharArray())
            {
                if (text[text.Length-1]==c)
                {
                    text = text.Remove(text.Length - 1);
                }
            }
            return text; 
        }

        public static string ReplcaceRegularVerbForm(this string text)
        {
          if ((text[text.Length-1]=='d')&&(text[text.Length - 2] == 'e'))
            {
                text = text.Remove(text.Length - 2);
            }

            return text;
        }

        public static string ReplcaceIrregularVerbForm(this string text, List<IrregularVerbForms> listIrregularVerbForms )
        {
           //TODO Read list from file

           

            return text;
        }

        public static bool IsContainUnneceseryCharacter(this string text, string charsCharacter = @"~`1234567890!@#$%^&*()_=+{[}]\|<>/")
        {
            var result = text.IndexOfAny(charsCharacter.ToCharArray()) != -1;
            if ((result==false)&&(text.Length>1))
            {
                text = text.Remove(text.Length - 1);
                result = text.IndexOfAny("\".,;:'?".ToCharArray()) != -1;
            }
            
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
