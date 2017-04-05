using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.DotNet.Cli.Utils;

namespace TooExe.Owl.Library.Model
{
    [Table("Articles", Schema = "Owl")]
    public class Article
    {
        [Key]
        public int Id { get; set; }

        public int IdOwlUser { get; set; }

        public string Name { get; set; }
        public string FileName { get; set; }

        [ForeignKey("IdOwlUser")]
        public virtual OwlUser OwlUser { get; set; }
    }
}