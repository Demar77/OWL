using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("EnglishPolish", Schema = "Owl")]
    public class EnglishPolish
    {
        [Key]
        public int Id { get; set; }

        public int IdEnglishWord { get; set; }

        public int IPolishWord { get; set; }

        [ForeignKey("IPolishWord")]
        public virtual PolishWord PolishWord { get; set; }

        [ForeignKey("IdEnglishWord")]
        public virtual EnglishWord EnglishWord { get; set; }
    }
}