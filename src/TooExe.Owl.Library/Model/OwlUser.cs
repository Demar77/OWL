using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("OwlUsers", Schema = "Owl")]
    public class OwlUser
    {
        public OwlUser()
        {
            Articles = new HashSet<Article>();
            KnownWords= new List<KnownWord>();
        }

        [Key]
        public int Id { get; set; }

        public string ExternalIdUser { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<KnownWord> KnownWords { get; set; }
    }
}