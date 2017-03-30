using System.Collections.Generic;

namespace TooExe.Owl.Library
{
    public interface IPreparingWords
    {
        void CalculateFreguency();

        List<FrequencyWordsList> GetFrequencyWordsListsByLevelFrequencyWords(double procent);
    }
}