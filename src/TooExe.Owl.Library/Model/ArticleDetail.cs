using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    public class ArticleDetail
    {
        [Key]
        public int Id { get; set; }

        public int IdTranslation { get; set; }
        public int IdArticle { get; set; }
    }
}