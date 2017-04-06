using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TooExe.Owl.Library.Model;

/*
Add-Migration NazwaAktualnegoPunktuBazy (np. DodaniePolaAdres)
Update-Database
*/

namespace TooExe.Owl.Mvc.Data
{
    internal interface IApplicationDbContext
    {
        DbSet<Article> Articles { get; set; }
        DbSet<ArticleDetail> ArticleDetails { get; set; }
    
        DbSet<EnglishWord> EnglishWords { get; set; }
        DbSet<KnownWord> KnownWords { get; set; }
        DbSet<PlayList> PlayLists { get; set; }
        DbSet<PlayListDetail> PlayListDetails { get; set; }
        DbSet<PolishWord> PolishWords { get; set; }
        DbSet<Translation> Translations { get; set; }
        DbSet<OwlUser> OwlUser { get; set; }
    }
}