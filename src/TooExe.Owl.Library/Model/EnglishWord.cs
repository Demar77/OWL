using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("EnglishWords", Schema = "Owl")]
    public class EnglishWord
    {
        public EnglishWord()
        {
            Translations = new HashSet<Translation>();
        }

        [Key]
        public int Id { get; set; }

        public string Word { get; set; }
        public string FileName { get; set; }
        public virtual ICollection<Translation> Translations { get; set; }
    }
}