using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    public class PolishWord
    {
        [Key]
        public int Id { get; set; }

        public int IdEnglishWord { get; set; }
        public string Translate { get; set; }
        public string FileName { get; set; }
    }
}