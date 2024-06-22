using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace EmptyCoreWebApplication.Models
{
	public class SignInModel

	{
		public int Id { get; set; } // Primary key
		[Required(ErrorMessage = "E-mail is required.")]
		public String? Email { get; set; } = String.Empty;
		[Required(ErrorMessage = "First Name is required.")]
		public String? FirstName { get; set; } = String.Empty;
		[Required(ErrorMessage = "Last Name is required.")]
		public String? LastName { get; set; } = String.Empty;
		
        public String? SelectedCourse { get; set; } = String.Empty;
		public String? Grade { get; set; } = String.Empty;

		[Required(ErrorMessage = "Password is required.")]
		public string Password { get; set; }
		public DateTime ApplyAt { get; set; }

		public SignInModel()
		{
			ApplyAt = DateTime.Now;
		}

		public String RoleId { get; set; } // Foreign key
	
	}
    
}

