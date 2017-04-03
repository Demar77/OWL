using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TooExe.Owl.Library.Model.Authentication;


namespace TooExe.Owl.Library.Model
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

       

        protected void BuildModel(ModelBuilder modelBuilder)
        {
            


        }

    }
}
