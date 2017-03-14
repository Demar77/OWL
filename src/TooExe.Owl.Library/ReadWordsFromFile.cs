using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TooExe.Owl.Library
{
    public class ReadWordsFromFile
    {
        public List<IrregularVerbForms> GetIrregularVerbForms(string path)
        {
            var result = new List<IrregularVerbForms>();

            try
            {
                // Open the text file using a stream reader.
                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8))
                {
                    // Read the stream to a string, and write the string to the console.
                    var verbs = sr.ReadToEnd().Split(';');
                    int i = 0;
                    for (int j = 0; j < verbs.Length - 1; j += 3)
                    {
                        IrregularVerbForms tmpIrregularVerbForms = new IrregularVerbForms
                        {
                            FirstForm = Regex.Replace(verbs[i++], @"\t|\n|\r", ""),
                            SecondForm = verbs[i++],
                            ThirdForm = verbs[i++]
                        };

                        result.Add(tmpIrregularVerbForms);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The file could not be read: {e.Message}");
            }
            return result;
        }

        public List<NounWordsList> GetIrregularNounForms(string path)
        {
            var result = new List<NounWordsList>();

            try
            {
                // Open the text file using a stream reader.
                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8))
                {
                    // Read the stream to a string, and write the string to the console.
                    var verbs = sr.ReadToEnd().Split(';');
                    int i = 0;
                    for (int j = 0; j < verbs.Length - 1; j += 3)
                    {
                        NounWordsList irregulatNoun = new NounWordsList
                        {
                            Singular = Regex.Replace(verbs[i++], @"\t|\n|\r", ""),
                            Plural = verbs[i++],
                        };

                        result.Add(irregulatNoun);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The file could not be read: {e.Message}");
            }
            return result;
        }

        public string GetStringFromFile(string path)
        {
            string result = String.Empty;

            try
            {
                // Open the text file using a stream reader.
                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8))
                {
                    // Read the stream to a string, and write the string to the console.
                    result = Regex.Replace(sr.ReadToEnd(), @"\t|\n|\r", " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: " + e.Message);
            }
            return result;
        }
    }
}