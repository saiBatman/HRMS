using System.ComponentModel.DataAnnotations;

namespace HRMSAPI.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
