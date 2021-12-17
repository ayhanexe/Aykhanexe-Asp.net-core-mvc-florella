using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HeaderController : Controller
    {
        private AppDbContext _context;

        public HeaderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Header model = _context.Header.FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Header header)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var _oldHeader = _context.Header.FirstOrDefault();
            _oldHeader.Logo = header.Logo;
            await _context.SaveChangesAsync();

            return View(header);
        }
    }
}
