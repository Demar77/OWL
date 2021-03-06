﻿using System.Collections.Generic;
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
    }
}