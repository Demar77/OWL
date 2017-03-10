using System.Collections.Generic;
using Xunit;

namespace TooExe.Owl.Library.UnitTests
{
   
    public class TestStringUtility
    {
       
        [Theory]
        [InlineData(@"This is  my example finished bit")]
        [InlineData(@"This 12312 @$FWF WEsdfgsdfs is;  my, example asdfasdas.sdf Finished bitten")]
        public void ToWordList_DirtyString_ExpectedWord(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = new List<string> { "this", "is", "my", "example", "finish", "bite" };

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
                Assert.False(true,"No string in input.");
            }
        }

        [Theory]
        [InlineData(@"Abcdef123")]
        [InlineData(@"Abcdef123jk")]
        [InlineData(@"Abcdef123j")]
        [InlineData(@"Abcdef123dfgdfg")]
        [InlineData(@"abcd123!@#234sdfgdgerge2342!$@%#^^#")]
        [InlineData(@"abcd")]
        [InlineData(@"ab")]
        [InlineData(@"a")]
        public void HaveTwoOrMoreUpperCaseLetter_StringDontContainTwoOrMoreUpperCaseLetter_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = false;

            // Act on the object or method under test.
            var actual = input.HaveTwoOrMoreUpperCaseLetter();

            // Assert that the expected results have occurred.
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"AB")]
        [InlineData(@"ABC")]
        [InlineData(@"AbcDef123")]
        [InlineData(@"Abcdef123G")]
        [InlineData(@"AAbcdef123G")]
        [InlineData(@"AAbcdef123GF")]
        [InlineData(@"abcd123!@#KLsdfgdgerge2342!$@%#^^#")]
        public void HaveTwoOrMoreUpperCaseLetter_StringContainTwoOrMoreUpperCaseLetter_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;

            // Act on the object or method under test.
            var actual = input.HaveTwoOrMoreUpperCaseLetter();

            // Assert that the expected results have occurred.
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Forest\"")]
        [InlineData("Forest.")]
        [InlineData("Forest,")]
        [InlineData("Forest;")]
        [InlineData("Forest:")]
        [InlineData("Forest'")]
        [InlineData("Forest?")]
        public void RemoveLastCharByLists_ExpectedCharToEndString_RemoveLastChar(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = "Forest";

            // Act on the object or method under test.
            string actual = input.RemoveLastCharByLists();

            // Assert that the expected results have occurred.
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"12312312312")]
        public void IsContainUnneceseryCharacter_InsertUnneceseryCharacter_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;

            // Act on the object or method under test.
            var actual = input.IsContainUnneceseryCharacter();

            // Assert that the expected results have occurred.
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"12312312312")]
        [InlineData(@"ReD")]
        [InlineData(@"Forest/")]
        [InlineData(@"Forest.House")]
        [InlineData(@"Forest.house")]
        [InlineData(@"Forest?house")]
        [InlineData(@"Forest,house")]
        public void IsBadWord_InsertBadWord_True(string input)
        {
            // Arrange all necessary preconditions and inputs.
            var expected = true;

            // Act on the object or method under test.
            var actual = input.IsBadWord();

            // Assert that the expected results have occurred.
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("bend", "bend")]
        [InlineData("bent", "bend")]
        [InlineData("bite", "bite")]
        [InlineData("bit", "bite")]
        [InlineData("bitten", "bite")]
        public void ReplcaceIrregularVerbForm_ExpectedIrregularVerb_ReplaceToFirstForm(string input, string expected)
        {
            // Arrange all necessary preconditions and inputs.

            // Act on the object or method under test.
            string actual = input.ReplcaceIrregularVerbForm();

            // Assert that the expected results have occurred.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReplcaceRegularVerbForm_InputReguralVerb_GetFirstFormVerb()
        {
            // Arrange all necessary preconditions and inputs.
            string input = "finished";
            var expected = "finish";

            // Act on the object or method under test.
            var actual = input.ReplcaceRegularVerbForm();

            // Assert that the expected results have occurred.
            Assert.Equal(expected, actual);
        }
    }
}