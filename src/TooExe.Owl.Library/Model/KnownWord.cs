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

        public int IdTranslation { get; set; }
        public int IdOwlUser { get; set; }

        [ForeignKey("IdOwlUser")]
        public virtual OwlUser OwlUser { get; set; }

        [ForeignKey("IdTranslation")]
        public virtual Translation Translation { get; set; }
    }
}