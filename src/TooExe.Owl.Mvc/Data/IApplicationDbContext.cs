using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TooExe.Owl.Mvc.Data
{
    internal interface IApplicationDbContext
    {
        DbSet<EnglishWord> EnglishWords { get; set; }
    }

    public class EnglishWord
    {
        [Key]
        public string Id { get; set; }

        public string Word { get; set; }
        public string FileName { get; set; }
    }
}