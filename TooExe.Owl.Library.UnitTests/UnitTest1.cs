using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestInitialize] and [TestCleanup] at the individual test level, [ClassInitialize] and [ClassCleanup] at the class level.

        string input = string.Empty;


        [TestInitialize()]
        public void Initialize()
        {
            string path = @"d:\test.txt";
            input = System.IO.File.ReadAllText(path);
        }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]
        [DataRow(@"This is  my example")]

        public void ToWordList_DirtyString_FourExpectedWord(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = new List<string> { "This", "is", "my", "example" };

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
        [DataRow(@"Abcdef123")]
        [DataRow(@"Abcdef123jk")]
        [DataRow(@"Abcdef123j")]
        [DataRow(@"Abcdef123dfgdfg")]
        [DataRow(@"abcd123!@#234sdfgdgerge2342!$@%#^^#")]
        [DataRow(@"abcd")]
        [DataRow(@"ab")]
        [DataRow(@"a")]
        public void HaveTwoOrMoreUpperCaseLetter_StringDontContainTwoOrMoreUpperCaseLetter_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = false;

            // Act on the object or method under test.
            var actual = input.HaveTwoOrMoreUpperCaseLetter();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(@"AB")]
        [DataRow(@"ABC")]
        [DataRow(@"AbcDef123")]
        [DataRow(@"Abcdef123G")]
        [DataRow(@"AAbcdef123G")]
        [DataRow(@"AAbcdef123GF")]
        [DataRow(@"abcd123!@#KLsdfgdgerge2342!$@%#^^#")]
        public void HaveTwoOrMoreUpperCaseLetter_StringContainTwoOrMoreUpperCaseLetter_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;


            // Act on the object or method under test.
            var actual = input.HaveTwoOrMoreUpperCaseLetter();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow('.')]
        [DataRow(',')]
        [DataRow(';')]
        [DataRow(':')]
        public void IsCharacterDontAdd_ExpectedChar_True(char input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;

            // Act on the object or method under test.
            var actual = input.IsCharacterDontAdd();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow('j')]
        [DataRow('-')]
        [DataRow('3')]
        [DataRow('&')]
        public void IsCharacterDontAdd_ExpectedChar_False(char input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = false;

            // Act on the object or method under test.
            var actual = input.IsCharacterDontAdd();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(@"12312312312")]
        public void IsContainUnneceseryCharacter_InsertUnneceseryCharacter_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;
            
            // Act on the object or method under test.
            var actual = input.IsContainUnneceseryCharacter();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }

       
    }
}
