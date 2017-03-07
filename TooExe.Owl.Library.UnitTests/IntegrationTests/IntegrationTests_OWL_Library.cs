using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests.IntegrationTests
{
    [TestClass]
    public class IntegrationTests_OWL_Library
    {
        [TestMethod]
        public void CanCreateWordList()
        {
            // Arrange all necessary preconditions and inputs.
            var expected = new List<string> { "this", "is", "my", "test", "this", "is", "my", "first", "word", "finish", "finish" };
            //string inputPath = @"C:\_repo\OWL\TooExe.Owl.Library.UnitTests\TestFiles\SmallPartOfBookToTest.txt";
            string inputPath = @"SmallPartOfBookToTest.txt";
            var input = new ReadWordsFromFile().GetStringFromFile(inputPath);

            // Act on the object or method under test.
            var actual = input.ToWordList() as List<string>;

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void CanCalculateFreguencyWords()
        {
            // Arrange all necessary preconditions and inputs.
            var _listFrequency = new List<FrequencyWordsList>();
            string inputPath = @"C:\_repo\OWL\TooExe.Owl.Library.UnitTests\TestFiles\SmallPartOfBookToTest.txt";
            var input = new ReadWordsFromFile().GetStringFromFile(inputPath);
            var _listWord = input.ToWordList().ToList();
            var expected = new List<FrequencyWordsList>();

            expected.Add(new FrequencyWordsList { Word = "this", Frequency = 2 });
            expected.Add(new FrequencyWordsList { Word = "is", Frequency = 2 });
            expected.Add(new FrequencyWordsList { Word = "my", Frequency = 2 });
            expected.Add(new FrequencyWordsList { Word = "test", Frequency = 1 });
            expected.Add(new FrequencyWordsList { Word = "first", Frequency = 1 });
            expected.Add(new FrequencyWordsList { Word = "word", Frequency = 1 });
            expected.Add(new FrequencyWordsList { Word = "finish", Frequency = 2 });

            // Act on the object or method under test.
            var preparingWords = new PreparingWords(_listWord, _listFrequency);
            preparingWords.CalculateFreguency();
            var actual = _listFrequency;

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Word, actual[i].Word);
                Assert.AreEqual(expected[i].Frequency, actual[i].Frequency, " Word: " + expected[i].Word);
            }
        }

    }
}