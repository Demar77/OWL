using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests.IntegrationTests
{
    [TestClass]
    public class IntegrationTestsOwlLibrary
    {
        [TestInitialize()]
        public void Initialize() { }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]
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
                Assert.AreEqual(expected.Count, actual.Count);

                for (var i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(expected[i], actual[i]);
                }
            }
            else
            {
                Assert.Fail("String not loaded from file.");
            }
        }

        [TestMethod]
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
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Word, actual[i].Word);
                Assert.AreEqual(expected[i].Frequency, actual[i].Frequency, " Word: " + expected[i].Word);
            }
        }

        [TestMethod]
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
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].FirstForm, actual[i].FirstForm);
                Assert.AreEqual(expected[i].SecondForm, actual[i].SecondForm);
                Assert.AreEqual(expected[i].ThirdForm, actual[i].ThirdForm);
            }
        }

        [TestMethod]
        public void CanGetStringFromFile()
        {
            // Arrange all necessary preconditions and inputs.
            var rootPath = System.AppContext.BaseDirectory;
            string inputPath = rootPath + @"/TestFiles/SmallPartOfBookToTest.txt";

            var expected = 57;

            // Act on the object or method under test.
            var actual = new ReadWordsFromFile().GetStringFromFile(inputPath);

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual.Length);
        }
    }
}