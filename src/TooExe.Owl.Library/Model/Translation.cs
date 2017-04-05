using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    [Table("Translations", Schema = "Owl")]
    public class Translation
    {
        public Translation()
        {
            PlayListDetails = new HashSet<PlayListDetail>();
            ArticleDetails = new HashSet<ArticleDetail>();
        }

        [Key]
        public int Id { get; set; }

        public int IdKnownWord { get; set; }
        public int IdEnglishWord { get; set; }
        public int IdPolishWord { get; set; }
        public virtual ICollection<PlayListDetail> PlayListDetails { get; set; }

        [ForeignKey("IdPolishWord")]
        public virtual PolishWord PolishWord { get; set; }

        [ForeignKey("IdEnglishWord")]
        public virtual EnglishWord EnglishWord { get; set; }

        public virtual ICollection<ArticleDetail> ArticleDetails { get; set; }

        [ForeignKey("IdKnownWord")]
        public virtual KnownWord KnownWord { get; set; }
    }
}