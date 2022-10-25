using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ContactPro.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50,ErrorMessage="The {0} must be at least {2} and max {1} characters long.", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and max {1} characters long.", MinimumLength = 2)]
        public string? LastName { get; set; }

        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        // Navigation Properties
        // Old (Deleted on Follow long After Finish?!) // TODO: Make relationship to Contact Model
        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
        // Old (Deleted on Follow long After Finish?!) // TODO: Make relationship to Category Model
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

    }
}
