using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreWebApplication.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
