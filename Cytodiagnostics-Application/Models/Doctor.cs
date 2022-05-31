using System.ComponentModel.DataAnnotations;

namespace Cytodiagnostics_Application.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Imię")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name ="Nazwisko")]
        [Required]
        [MaxLength(50)]

        public string Surname { get; set; }
    }
}
