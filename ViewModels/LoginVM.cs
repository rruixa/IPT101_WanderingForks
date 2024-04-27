using System.ComponentModel.DataAnnotations;

namespace IPT101_WanderingForks.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool RememberMe { get; set;}
    }
}
