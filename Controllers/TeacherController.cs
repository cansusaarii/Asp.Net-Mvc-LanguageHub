using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreWebApplication.Controllers
{
	public class TeacherController: Controller
	{
		[Authorize(Roles = "teacher")]
		public IActionResult TeacherDashboard()
		{
			return View();
		}
	}
}
