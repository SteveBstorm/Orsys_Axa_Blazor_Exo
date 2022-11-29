using System.ComponentModel.DataAnnotations;

namespace Orsys_Axa_Blazor_Exo.Models
{
    public class UserForm
    {
        [Required]
        public string Nom { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Tel { get; set; }
        [Required]
        [MinLength(10), MaxLength(140)]
        public string Message { get; set; }
        public string Couleur { get; set; }
    }
}
