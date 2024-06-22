
using EmptyCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace EmptyCoreWebApplication.Controllers
{
	public class PaymentController: Controller
	{
        public IActionResult Payment()
        {
            return View();
        }
    }
}
