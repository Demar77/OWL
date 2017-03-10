using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace TooExe.Owl.Library.UnitTests.IntegrationTests
{
    public class IntegrationTestsOwlLibrary
    {
        [Fact]
        public void CanCreateWordList()
        {
            // Arrange all necessary preconditions and inputs.
            var expected = new List<string> { "this", "is", "my", "test", "this", "is", "my", "first", "word", "finish", "finish" };
            var rootPath = System.AppContext.BaseDirectory;
            string inputPath = rootPath + @"/TestFiles/SmallPartOfBookToTest.txt";
            var input = new ReadWordsFromFile().GetStringFromFile(inputPath);

            // Act on the object or method under test.
            var actual = input.ToWordList() as List<string>;

            // Assert that the expected results have occurred.
            if (actual != null)
            {
                Assert.Equal(expected.Count, actual.Count);

                for (var i = 0; i < expected.Count; i++)
                {
                    Assert.Equal(expected[i], actual[i]);
                }
            }
            else
            {
                //  Assert.Fail("String not loaded from file.");
            }
        }

        [Fact]
        public void CanCalculateFreguencyWords()
        {
            // Arrange all necessary preconditions and inputs.
            var listFrequency = new List<FrequencyWordsList>();
            var rootPath = System.AppContext.BaseDirectory;
            string inputPath = rootPath + @"/TestFiles/SmallPartOfBookToTest.txt";
            var input = new ReadWordsFromFile().GetStringFromFile(inputPath);
            var listWord = input.ToWordList().ToList();
            var expected = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "this", Frequency = 2},
                new FrequencyWordsList {Word = "is", Frequency = 2},
                new FrequencyWordsList {Word = "my", Frequency = 2},
                new FrequencyWordsList {Word = "test", Frequency = 1},
                new FrequencyWordsList {Word = "first", Frequency = 1},
                new FrequencyWordsList {Word = "word", Frequency = 1},
                new FrequencyWordsList {Word = "finish", Frequency = 2}
            };

            // Act on the object or method under test.
            var preparingWords = new PreparingWords(listWord, listFrequency);
            preparingWords.CalculateFreguency();
            var actual = listFrequency;

            // Assert that the expected results have occurred.
            Assert.Equal(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Word, actual[i].Word);
                Assert.Equal(expected[i].Frequency, actual[i].Frequency);
                //Assert.Equal(expected[i].Frequency, actual[i].Frequency, " Word: " + expected[i].Word.ToString());
            }
        }

        [Fact]
        public void CanGetIrregularVerbFormsFromFile()
        {
            // Arrange all necessary preconditions and inputs.
            var rootPath = System.AppContext.BaseDirectory;
            string inputPath = rootPath + @"/TestFiles/IrregularVerbForms.txt";

            var expected = new List<IrregularVerbForms>
            {
                new IrregularVerbForms
                {
                    FirstForm = "bend",
                    SecondForm = "bent",
                    ThirdForm = "bent"
                },
                new IrregularVerbForms
                {
                    FirstForm = "bite",
                    SecondForm = "bit",
                    ThirdForm = "bitten"
                }
            };

            // Act on the object or method under test.
            var actual = new ReadWordsFromFile().GetIrregularVerbForms(inputPath);

            // Assert that the expected results have occurred.
            Assert.Equal(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].FirstForm, actual[i].FirstForm);
                Assert.Equal(expected[i].SecondForm, actual[i].SecondForm);
                Assert.Equal(expected[i].ThirdForm, actual[i].ThirdForm);
            }
        }

        [Fact]
        public void CanGetIrregularVerbFormsFromFile_ThrowException()
        {
            // Arrange all necessary preconditions and inputs.
            string inputPath = @"/badpath/filedontexist.txt";
            //return 0 allways when catch exception
            var expected = 0;

            // Act on the object or method under test.
            var actual = new ReadWordsFromFile().GetIrregularVerbForms(inputPath);

            // Assert that the expected results have occurred.
            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void CanGetStringFromFile()
        {
            // Arrange all necessary preconditions and inputs.
            var rootPath = System.AppContext.BaseDirectory;
            string inputPath = rootPath + @"/TestFiles/SmallPartOfBookToTest.txt";

            var expected = 57;

            // Act on the object or method under test.
            var actual = new ReadWordsFromFile().GetStringFromFile(inputPath);

            // Assert that the expected results have occurred.
            Assert.Equal(expected, actual.Length);
        }

        [Fact]
        public void CanGetStringFromFile_ThrowException()
        {
            // Arrange all necessary preconditions and inputs.
            string inputPath = @"/badpath/filedontexist.txt";
            //return 0 allways when catch exception
            var expected = 0;
            // Act on the object or method under test.
            var actual = new ReadWordsFromFile().GetStringFromFile(inputPath);

            // Assert that the expected results have occurred.
            Assert.Equal(expected, actual.Length);
        }

        [Fact]
        public void CanReplacePluralWords_ReplaceToSingular()
        {
            // Arrange all necessary preconditions and inputs.
            var rootPath = System.AppContext.BaseDirectory;
            string inputPath = rootPath + @"/TestFiles/NounListToTests.txt";
            var fileStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read);

            using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8))
            {
                // Read the stream to a string, and write the string to the console.
                var verbs = sr.ReadToEnd().Split(';');
                int i = 0;
                for (int j = 0; j < verbs.Length - 1; j += 3)
                {
                    string expected = Regex.Replace(verbs[i++], @"\t|\n|\r", "");
                    string actual = verbs[i++].ReplacePluralWords();
                    Assert.Equal(expected, actual);
                }
            }

            // Act on the object or method under test.

            // Assert that the expected results have occurred.
        }
    }
}