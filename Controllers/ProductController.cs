using EmptyCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmptyCoreWebApplication.Controllers
{
    public class ProductController: Controller
    {
        private readonly RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }
        public IActionResult Get(int Id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(Id));
            return View(product);
        }
    }
}
