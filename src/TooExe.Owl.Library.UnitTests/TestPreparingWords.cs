using System.Collections.Generic;
using Xunit;

namespace TooExe.Owl.Library.UnitTests
{
    public class TestPreparingWords
    {
        [Fact]
        public void CalculateFreguency_InsertDuplicateWords_True()
        {
            // Arrange all necessary preconditions and inputs.
            var listWord = new List<string> { "red", "pink", "red", "yellow", "red" };
            var listFrequency = new List<FrequencyWordsList>();
            var expected = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 3},
                new FrequencyWordsList {Word = "pink", Frequency = 1},
                new FrequencyWordsList {Word = "yellow", Frequency = 1}
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
            }
        }

        [Fact]
        public void GetFrequencyWordsListsByLevelFrequencyWords_InsertFrequencyList_GetListGrequencyOnWriteLevel_100proc()
        {
            // Arrange all necessary preconditions and inputs.
            var frequencyList = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 3},
                new FrequencyWordsList {Word = "pink", Frequency = 1},
                new FrequencyWordsList {Word = "yellow", Frequency = 1}
            };
            var expected = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 3},
                new FrequencyWordsList {Word = "pink", Frequency = 1},
                new FrequencyWordsList {Word = "yellow", Frequency = 1}
            };
            // Act on the object or method under test.

            var actual = new PreparingWords(frequencyList).GetFrequencyWordsListsByLevelFrequencyWords(100);

            // Assert that the expected results have occurred.
            Assert.Equal(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Word, actual[i].Word);
                Assert.Equal(expected[i].Frequency, actual[i].Frequency);
            }
        }

        [Fact]
        public void GetFrequencyWordsListsByLevelFrequencyWords_InsertFrequencyList_GetListGrequencyOnWriteLevel_50proc()
        {
            // Arrange all necessary preconditions and inputs.
            var frequencyList = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 100},
                new FrequencyWordsList {Word = "pink", Frequency = 100},
                new FrequencyWordsList {Word = "yellow", Frequency = 100}
            };
            var expected = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 100},
                new FrequencyWordsList {Word = "pink", Frequency = 50},
            };
            // Act on the object or method under test.
            var actual = new PreparingWords(frequencyList).GetFrequencyWordsListsByLevelFrequencyWords(100);

            // Assert that the expected results have occurred.
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Word, actual[i].Word);
                Assert.Equal(expected[i].Frequency, actual[i].Frequency);
            }
        }
    }
}