using EmptyCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreWebApplication.Controllers
{
	public class UsersController : Controller
	{
		private readonly UsersContext _context;
		public UsersController(UsersContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var users = _context.SignedInModels.ToList();
			return View(users);
		}
	}
}
