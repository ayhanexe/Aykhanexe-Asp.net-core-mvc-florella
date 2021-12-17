using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FooterController : Controller
    {
        private AppDbContext _context;

        public FooterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Footer footer = _context.Footer.FirstOrDefault();
            return View(footer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Footer footer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var _oldFooter = _context.Footer.FirstOrDefault();
            _oldFooter.Logo = footer.Logo;
            _oldFooter.Facebook = footer.Facebook;
            _oldFooter.Linkedin = footer.Linkedin;

            await _context.SaveChangesAsync();

            return View(footer);
        }
    }
}
