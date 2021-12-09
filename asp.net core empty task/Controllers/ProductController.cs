using asp.net_core_empty_task.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace asp.net_core_empty_task.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Take(4).Include(products => products.Category).ToList();
            ViewBag.SkipCount = products.Count;
            return View();
        }

        public PartialViewResult LoadMore(int skip)
        {
            var products = _context.Products.Skip(skip).Take(4).Include(products => products.Category).ToList();
            return PartialView("_ProductsPartialView", products);
        }
    }
}
