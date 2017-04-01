using System.ComponentModel.DataAnnotations;

namespace TooExe.Owl.Library.Model.Authentication
{
   

    public partial class AspNetRoleClaim
    {
        public int Id { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        [Required]
        [StringLength(450)]
        public string RoleId { get; set; }

        public virtual AspNetRole AspNetRole { get; set; }
    }
}
