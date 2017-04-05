using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    public class Translation
    {
        [Key]
        public int Id { get; set; }

        public int IdEnglishWord { get; set; }
        public int IdPolishWord { get; set; }
    }
}