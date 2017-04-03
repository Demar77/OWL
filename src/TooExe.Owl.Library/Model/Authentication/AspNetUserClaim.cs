using System.ComponentModel.DataAnnotations;

namespace TooExe.Owl.Library.Model.Authentication
{
    

    public partial class AspNetUserClaim
    {
        public int Id { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}
