using EmptyCoreWebApplication.Views.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmptyCoreWebApplication.Models
{
	public class UsersContext : IdentityDbContext<IdentityUser>
	{
		public DbSet<SignInModel> SignedInModels { get; set; }
		public DbSet<IdentityRole> Roles { get; set; }

		public UsersContext(DbContextOptions<UsersContext> options)
			: base(options)
		{

		}
		

	}
	
}
