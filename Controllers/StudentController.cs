using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreWebApplication.Controllers
{
	public class StudentController: Controller
	{
		[Authorize(Roles = "student")]
		public IActionResult StudentDashboard()
		{
			return View();
		}
	}
}
