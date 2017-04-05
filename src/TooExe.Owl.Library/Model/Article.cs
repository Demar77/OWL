using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        public int IdProfile { get; set; }

        public string Name { get; set; }
        public string FileName { get; set; }
    }
}