using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library
{
    internal interface IReadWordsFromFile
    {
        List<IrregularForms> GetIrregularForms(string path);

        List<NounWordsList> GetIrregularNounForms(string path);

        string GetStringFromFile(string path);
    }
}