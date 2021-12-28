using asp.net_core_empty_task.Areas.Admin.ViewModels;
using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using asp.net_core_empty_task.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize()]
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

        public async Task<IActionResult> List()
        {
            var model = await _context.SliderItem.ToListAsync();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(SliderItem sliderItem)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!sliderItem.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photo", "Unsupported File Type!");
                return View();
            }

            if (sliderItem.Photo.Length > 1024 * 1000)
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

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.SliderItem.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.SliderItem.Remove(item);
            await _context.SaveChangesAsync();

            string wwwRoot = _env.WebRootPath;
            string filePath = item.image;

            string finalPath = Path.Combine(wwwRoot, "img", filePath);

            await FileUtils.Delete(finalPath);

            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult> EditSliderItem(SliderItem _item)
        {
            var item = await _context.SliderItem.FindAsync(_item.id);

            if (item == null)
            {
                return NotFound();
            }
            string FileName = _item.Photo.FileName;
            string wwwRoot = _env.WebRootPath;

            string path = Path.Combine(wwwRoot, "img", FileName);
            string oldPath = Path.Combine(wwwRoot, "img", item.image);


            await FileUtils.Delete(oldPath);

            FileStream stream = new FileStream(path, FileMode.Create);

            await _item.Photo.CopyToAsync(stream);

            stream.Close();


            item.image = _item.Photo.FileName;
            await _context.SaveChangesAsync();

            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> AddSlider()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddMultiple(SliderMultipleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var slider = new Slider { desc = "Default Description", logo = "Default Logo", title = "Default Title" };
            await _context.Slider.AddAsync(slider);
            await _context.SaveChangesAsync();

            foreach (var item in model.sliderItems)
            {

                if (!item.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("Photo", "Unsupported File Type!");
                    return View();
                }

                if (item.Length > 1024 * 1000)
                {
                    ModelState.AddModelError("Photo", "File size must be lower than 1mb!");
                    return View();
                }

                string FileName = item.FileName;
                string wwwRoot = _env.WebRootPath;

                string path = Path.Combine(wwwRoot, "img", FileName);

                FileStream stream = new FileStream(path, FileMode.Create);

                await item.CopyToAsync(stream);

                stream.Close();

                var sliderItem = new SliderItem { image = item.FileName, slider = slider };

                await _context.SliderItem.AddAsync(sliderItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

    }
}
