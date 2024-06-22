using EmptyCoreWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Xml.Linq;

namespace EmptyCoreWebApplication.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UsersContext _context;

        public RegisterController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, UsersContext context, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
			_roleManager = roleManager;
			_context = context;
        }
        

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email};
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    _context.SignedInModels.Add(model);
                    await _context.SaveChangesAsync();

					if (!await _roleManager.RoleExistsAsync(model.RoleId))
					{
						var role = new IdentityRole(model.RoleId);
						await _roleManager.CreateAsync(role);
					}
					await _userManager.AddToRoleAsync(user, model.RoleId);
					
					await _signInManager.SignInAsync(user, isPersistent: false);
					if (model.RoleId == "teacher")
					{
						return RedirectToAction("TeacherDashboard", "Teacher");
					}
					else if (model.RoleId == "student")
					{
						return RedirectToAction("StudentDashboard", "Student");
					}

					
				}
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);

        }
    }
}
