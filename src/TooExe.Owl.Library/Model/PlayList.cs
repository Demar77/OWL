using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("PlayLists", Schema = "Owl")]
    public class PlayList
    {
        [Key]
        public int Id { get; set; }

        public int IdDocument { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
    }
}