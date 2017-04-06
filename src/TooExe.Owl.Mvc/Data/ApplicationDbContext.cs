using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TooExe.Owl.Library.Model;
using TooExe.Owl.Mvc.Models;

namespace TooExe.Owl.Mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleDetail> ArticleDetails { get; set; }
        public DbSet<EnglishWord> EnglishWords { get; set; }
        public DbSet<KnownWord> KnownWords { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<PlayListDetail> PlayListDetails { get; set; }
        public DbSet<PolishWord> PolishWords { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<OwlUser> OwlUser { get; set; }
        
    }
}