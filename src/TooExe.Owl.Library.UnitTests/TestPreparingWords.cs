using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        public void GetFrequencyWordsListsByLevelFrequencyWords_InsertFrequencyListEqual_GetListGrequencyOnWriteLevel_50proc()
        {
            // Arrange all necessary preconditions and inputs.
            var frequencyList = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 25},
                new FrequencyWordsList {Word = "pink", Frequency = 25},
                new FrequencyWordsList {Word = "yellow", Frequency = 25},
                new FrequencyWordsList {Word = "blue", Frequency = 25}
            };
            var expected = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 25},
                new FrequencyWordsList {Word = "pink", Frequency = 25},
              };
            // Act on the object or method under test.
            var actual = new PreparingWords(frequencyList).GetFrequencyWordsListsByLevelFrequencyWords(50);

            // Assert that the expected results have occurred.
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Word, actual[i].Word);
            }
        }

        [Fact]
        public void GetFrequencyWordsListsByLevelFrequencyWords_InsertFrequencyListDifrentValue_GetListGrequencyOnWriteLevel_75proc()
        {
            // Arrange all necessary preconditions and inputs.
            var frequencyList = new List<FrequencyWordsList>
            {
                new FrequencyWordsList {Word = "red", Frequency = 20},
                new FrequencyWordsList {Word = "pink", Frequency = 25},
                new FrequencyWordsList {Word = "yellow", Frequency = 25},
                new FrequencyWordsList {Word = "blue", Frequency = 25}
            };
            var expected = new List<FrequencyWordsList>
            {
                 new FrequencyWordsList {Word = "pink", Frequency = 25},
                new FrequencyWordsList {Word = "yellow", Frequency = 25},
                new FrequencyWordsList {Word = "blue", Frequency = 25}
              };
            // Act on the object or method under test.
            var actual = new PreparingWords(frequencyList).GetFrequencyWordsListsByLevelFrequencyWords(75);

            // Assert that the expected results have occurred.
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Word, actual[i].Word);
            }
        }

      

    }
}