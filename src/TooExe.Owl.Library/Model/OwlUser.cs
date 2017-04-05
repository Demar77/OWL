using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model
{
    public class OwlUser
    {
        [Key]
        public int Id { get; set; }

        public string ExternalIdUser { get; set; }
        public string Name { get; set; }
    }
}