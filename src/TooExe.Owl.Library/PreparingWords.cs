using System;
using System.Collections.Generic;
using System.Linq;

namespace TooExe.Owl.Library
{
    public class PreparingWords : IPreparingWords
    {
        private readonly List<string> _listWord;
        public List<FrequencyWordsList> ListFrequency;

        public PreparingWords(List<string> listWord, List<FrequencyWordsList> listFrequency)
        {
            _listWord = listWord;
            ListFrequency = listFrequency;
        }

        public PreparingWords(List<FrequencyWordsList> listFrequency)
        {
            ListFrequency = listFrequency;
        }

        public void CalculateFreguency()
        {
            foreach (var word in _listWord)
            {
                FrequencyWordsList findWord = ListFrequency.FirstOrDefault(x => x.Word == word);
                if (findWord != null)
                {
                    findWord.Frequency++;
                }
                else
                {
                    ListFrequency.Add(new FrequencyWordsList { Word = word, Frequency = 1 });
                }
            }
        }

        public List<FrequencyWordsList> GetFrequencyWordsListsByLevelFrequencyWords(double procent)
        {
            ListFrequency = ListFrequency.OrderBy(p => p.Word).ToList();
            ListFrequency.Sort((s1, s2) => s2.Frequency.CompareTo(s1.Frequency));
            //TODO secure 101% or -5% and tolerance in decimal maybe 0.01
            //expected.Sort((s1, s2) => s2.Frequency.CompareTo(s1.Frequency));
            //var sortedList = yourList.OrderBy(x => x.Score);
            if (procent == 100)
            {
                return ListFrequency;
            }
            else
            {
                int occurrenceWords = 0;
                foreach (var lf in ListFrequency)
                {
                    occurrenceWords += lf.Frequency;
                }
                double occurrenceWordsEnough = (procent * occurrenceWords) / 100;
                var result = new List<FrequencyWordsList>();
                double actualValueFrequency = 0;
                foreach (var word in ListFrequency)
                {
                    if (actualValueFrequency <= occurrenceWordsEnough)
                    {
                        result.Add(word);
                    }
                    else
                    {
                        break;
                    }
                    actualValueFrequency += word.Frequency;
                }
                return result;
            }
        }
    }
}