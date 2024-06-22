using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreWebApplication.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
     
}
