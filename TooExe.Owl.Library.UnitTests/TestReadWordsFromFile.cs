using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests
{
    [TestClass]
    public class TestReadWordsFromFile
    {
        //[TestInitialize] and [TestCleanup] at the individual test level, [ClassInitialize] and [ClassCleanup] at the class level.




        [TestInitialize()]
        public void Initialize() { }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]
        public void GetIrregularVerbForms_ReadFromFile_GetListIrregularVerbs()
        {
            // Arrange all necessary preconditions and inputs.
            string inputPath = @"C:\_repo\OWL\TooExe.Owl.Library.UnitTests\TestFiles\IrregularVerbForms.txt";

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
        public void GetStringFromFile_ReadFromFile_GetString()
        {
            // Arrange all necessary preconditions and inputs.
            string inputPath = @"C:\_repo\OWL\TooExe.Owl.Library.UnitTests\TestFiles\SmallPartOfBookToTest.txt";

            var expected = 57;




            // Act on the object or method under test.
            var actual = new ReadWordsFromFile().GetStringFromFile(inputPath);

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual.Length);
        }

        [TestMethod]

        public void ToWordList_DirtyString_FourExpectedWord()
        {
            // Arrange all necessary preconditions and inputs.
            var expected = new List<string> { "this", "is", "my", "test", "this", "is", "my", "first", "word", "finish", "finish" };
            string inputPath = @"C:\_repo\OWL\TooExe.Owl.Library.UnitTests\TestFiles\SmallPartOfBookToTest.txt";
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
        public void CalculateFreguency_InsertWordsFromFile_True()
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
            expected.Add(new FrequencyWordsList { Word = "finish", Frequency = 1 });

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
