using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("KnownWords", Schema = "Owl")]
    public class KnownWord
    {
        public KnownWord()
        {
            Translations = new HashSet<Translation>();
        }

        [Key]
        public int Id { get; set; }

        public int IdTranslation { get; set; }

        public virtual ICollection<Translation> Translations { get; set; }
    }
}