using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    public class EnglishWord
    {
        [Key]
        public int Id { get; set; }

        public string Word { get; set; }
        public string FileName { get; set; }
    }
}