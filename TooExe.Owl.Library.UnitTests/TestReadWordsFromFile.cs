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

      
    }
}