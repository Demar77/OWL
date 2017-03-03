using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooExe.Owl.Library
{
  public  class PreparingWords
  {
        private List<string> _listWord= new List<string>();
        public List<FrequencyWordsList> _listFrequency= new List<FrequencyWordsList>();

        public PreparingWords(List<string> listWord, List<FrequencyWordsList> listFrequency)
        {
            _listWord = listWord;
            _listFrequency = listFrequency;
        }

      public void CalculateFreguency()
      {

            foreach (var word in _listWord)
          {


                FrequencyWordsList findWord = _listFrequency.FirstOrDefault(x => x.Word == word);
                if (findWord != null)
                {
                    findWord.Frequency++;
                }
              else
              {
                    _listFrequency.Add(new FrequencyWordsList{Word = word, Frequency = 1} );
              }
             
            }
      }

      public void CalculateRegularVerbs(List<InregularVerbForms> listInregularVerbForms)
      {
          
      }

        
    }
}
