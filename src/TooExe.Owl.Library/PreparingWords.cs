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
            //TODO secure 101% or -5% and tolerance in decimal maybe 0.01
            if (procent == 100)
            {
                return ListFrequency;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}