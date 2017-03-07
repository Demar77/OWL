using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests
{
    [TestClass]
    public class TestPreparingWords
    {
        //[TestInitialize] and [TestCleanup] at the individual test level, [ClassInitialize] and [ClassCleanup] at the class level.

        public PreparingWords preparingWords;
        public List<string> _listWord;
        public List<FrequencyWordsList> _listFrequency;

        [TestInitialize()]
        public void Initialize()
        {
            _listWord = new List<string>();
            _listFrequency = new List<FrequencyWordsList>();
            preparingWords = new PreparingWords(_listWord, _listFrequency);
        }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]
        public void CalculateFreguency_InsertDuplicateWords_True()
        {
            // Arrange all necessary preconditions and inputs.
            _listWord = new List<string> { "red", "pink", "red", "yellow", "red" };
            var expected = new List<FrequencyWordsList>();
            expected.Add(new FrequencyWordsList { Word = "red", Frequency = 3 });
            expected.Add(new FrequencyWordsList { Word = "pink", Frequency = 1 });
            expected.Add(new FrequencyWordsList { Word = "yellow", Frequency = 1 });

            // Act on the object or method under test.
            preparingWords = new PreparingWords(_listWord, _listFrequency);
            preparingWords.CalculateFreguency();
            var actual = _listFrequency;

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Word, actual[i].Word);
                Assert.AreEqual(expected[i].Frequency, actual[i].Frequency);
            }
        }

        [TestMethod]
        public void ReplcaceRegularVerbForm_InputReguralVerb_GetFirstFormVerb()
        {
            // Arrange all necessary preconditions and inputs.
            string input = "finished";
            var expected = "finish";
            //string input = "ed";
            //var expected = "";

            // Act on the object or method under test.
            var actual = input.ReplcaceRegularVerbForm();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }
    }
}