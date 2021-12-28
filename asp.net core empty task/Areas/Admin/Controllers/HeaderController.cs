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
    public class HeaderController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public HeaderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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

            if (!header.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("photo", "unsupported file type!");
                return View();
            }

            if (header.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("photo", "file size must be lower than 1mb!");
                return View();
            }

            string filename = header.Photo.FileName;
            string wwwroot = _env.WebRootPath;

            string path = Path.Combine(wwwroot, "img", filename);

            FileStream stream = new FileStream(path, FileMode.Create);

            await header.Photo.CopyToAsync(stream);

            stream.Close();

            var _header = _context.Header.FirstOrDefault();

            _header.Logo = header.Photo.FileName;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
