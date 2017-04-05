using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("PlayListDetails", Schema = "Owl")]
    public class PlayListDetail
    {
        [Key]
        public int Id { get; set; }

        public int IdPlayList { get; set; }
        public int IdTranslation { get; set; }
    }
}