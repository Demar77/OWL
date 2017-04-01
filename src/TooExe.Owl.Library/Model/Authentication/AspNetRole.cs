using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TooExe.Owl.Library.Model.Authentication
{
    public partial class AspNetRole
    {
        
        public AspNetRole()
        {
            AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
            AspNetUsers = new HashSet<AspNetUser>();
        }

        [StringLength(450)]
        public string Id { get; set; }

        public string ConcurrencyStamp { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string NormalizedName { get; set; }

     
        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }

     
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
