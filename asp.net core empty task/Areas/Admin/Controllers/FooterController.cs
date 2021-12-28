using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize()]
    public class FooterController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public FooterController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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

            if (!footer.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("photo", "unsupported file type!");
                return View();
            }

            if (footer.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("photo", "file size must be lower than 1mb!");
                return View();
            }

            string filename = footer.Photo.FileName;
            string wwwroot = _env.WebRootPath;

            string path = Path.Combine(wwwroot, "img", filename);

            FileStream stream = new FileStream(path, FileMode.Create);

            await footer.Photo.CopyToAsync(stream);

            stream.Close();

            var _footer = _context.Footer.FirstOrDefault();

            _footer.Logo = footer.Photo.FileName;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
