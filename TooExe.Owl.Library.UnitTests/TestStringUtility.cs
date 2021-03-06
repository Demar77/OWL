using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests
{
    [TestClass]
    public class TestStringUtility
    {
        [TestInitialize()]
        public void Initialize() { }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]
        [DataRow(@"This is  my example finished bit")]
        [DataRow(@"This 12312 @$FWF WEsdfgsdfs is;  my, example asdfasdas.sdf Finished bitten")]
        public void ToWordList_DirtyString_ExpectedWord(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = new List<string> { "this", "is", "my", "example", "finish", "bite" };

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
                Assert.Fail("No string in input.");
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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Forest\"")]
        [DataRow("Forest.")]
        [DataRow("Forest,")]
        [DataRow("Forest;")]
        [DataRow("Forest:")]
        [DataRow("Forest'")]
        [DataRow("Forest?")]
        public void RemoveLastCharByLists_ExpectedCharToEndString_RemoveLastChar(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = "Forest";

            // Act on the object or method under test.
            string actual = input.RemoveLastCharByLists();

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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(@"12312312312")]
        [DataRow(@"ReD")]
        [DataRow(@"Forest/")]
        [DataRow(@"Forest.House")]
        [DataRow(@"Forest.house")]
        [DataRow(@"Forest?house")]
        [DataRow(@"Forest,house")]
        public void IsBadWord_InsertBadWord_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;

            // Act on the object or method under test.
            var actual = input.IsBadWord();

            // Assert that the expected results have occurred.
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("bend", "bend")]
        [DataRow("bent", "bend")]
        [DataRow("bite", "bite")]
        [DataRow("bit", "bite")]
        [DataRow("bitten", "bite")]
        public void ReplcaceIrregularVerbForm_ExpectedIrregularVerb_ReplaceToFirstForm(string input, string expected)
        {
            // Arrange all necessary preconditions and inputs.

            // Act on the object or method under test.
            string actual = input.ReplcaceIrregularVerbForm();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplcaceRegularVerbForm_InputReguralVerb_GetFirstFormVerb()
        {
            // Arrange all necessary preconditions and inputs.
            string input = "finished";
            var expected = "finish";

            // Act on the object or method under test.
            var actual = input.ReplcaceRegularVerbForm();

            // Assert that the expected results have occurred.
            Assert.AreEqual(expected, actual);
        }
    }
}