using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Cytodiagnostics_Application.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string Name { get; set; }


    }
}
