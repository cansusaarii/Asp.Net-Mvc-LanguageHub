using System.ComponentModel.DataAnnotations;

namespace EmptyCoreWebApplication.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Email is required.")]
        public string? Email { get; set; } = String.Empty;

		[Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = String.Empty;

        public bool RememberMe { get; set; }
    }
}
