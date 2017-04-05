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
        [Key]
        public int Id { get; set; }

        public int IdProfile { get; set; }

        public int IdTranslation { get; set; }
    }
}