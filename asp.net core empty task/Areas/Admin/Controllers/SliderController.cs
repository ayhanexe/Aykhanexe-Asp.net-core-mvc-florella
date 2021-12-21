using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(SliderItem sliderItem)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            if(!sliderItem.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photo", "Unsupported File Type!");
                return View();
            }

            if(sliderItem.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("Photo", "File size must be lower than 1mb!");
                return View();
            }

            string FileName = sliderItem.Photo.FileName;
            string wwwRoot = _env.WebRootPath;

            string path = Path.Combine(wwwRoot, "img", FileName);

            FileStream stream = new FileStream(path, FileMode.Create);

            await sliderItem.Photo.CopyToAsync(stream);

            stream.Close();

            sliderItem.image = sliderItem.Photo.FileName;
            await _context.SliderItem.AddAsync(sliderItem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
