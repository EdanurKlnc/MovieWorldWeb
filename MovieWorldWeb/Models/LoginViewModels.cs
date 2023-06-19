using System.ComponentModel.DataAnnotations;

namespace MovieWorldWeb.Models
{
    public class LoginViewModels
    {
        [Required]
        public string UserNameOrEmail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
