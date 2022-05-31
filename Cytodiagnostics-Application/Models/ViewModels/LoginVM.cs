using System.ComponentModel.DataAnnotations;

namespace Cytodiagnostics_Application.Models.View_Models
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set;}
    }
}
