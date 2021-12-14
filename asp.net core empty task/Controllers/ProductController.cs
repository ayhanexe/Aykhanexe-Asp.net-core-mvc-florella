using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<PartialViewResult> Api()
        {

            string searchString = HttpContext.Request.Query["search"].ToString().ToLower();
            List<Product> searchedProducts = await _context.Products.Where(p => p.Name.ToLower().Contains(searchString)).ToListAsync();

            return PartialView("_ProductSearchPartial", searchString == "" ? new List<Product>() : searchedProducts);
        }

        public PartialViewResult LoadMore(int skip)
        {
            var products = _context.Products.Skip(skip).Take(4).Include(products => products.Category).ToList();
            return PartialView("_ProductsPartialView", products);
        }
    }
}
