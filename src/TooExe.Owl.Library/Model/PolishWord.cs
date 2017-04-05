using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("PolishWords", Schema = "Owl")]
    public class PolishWord
    {
        [Key]
        public int Id { get; set; }

        public int IdEnglishWord { get; set; }
        public string Translate { get; set; }
        public string FileName { get; set; }
    }
}