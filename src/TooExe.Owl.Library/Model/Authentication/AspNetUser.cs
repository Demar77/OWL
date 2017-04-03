using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TooExe.Owl.Library.Model.Authentication
{
  

    public partial class AspNetUser
    {
       
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetRoles = new HashSet<AspNetRole>();
        }

        [StringLength(450)]
        public string Id { get; set; }

        public int AccessFailedCount { get; set; }

        public string ConcurrencyStamp { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool LockoutEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        [StringLength(256)]
        public string NormalizedEmail { get; set; }

        [StringLength(256)]
        public string NormalizedUserName { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public string SecurityStamp { get; set; }

        public bool TwoFactorEnabled { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }

      
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }

   
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

     
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
