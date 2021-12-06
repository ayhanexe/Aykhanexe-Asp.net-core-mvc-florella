using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using asp.net_core_empty_task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp.net_core_empty_task.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Slider slider = _context.Slider.FirstOrDefault();
            List<SliderItem> sliderItems = _context.SliderItem.ToList();
            VideoSection videoSection = _context.VideoSections.FirstOrDefault();
            List<VideoSectionItem> videoSectionItems = _context.VideoSectionsItems.ToList();

            HomeIndexModelView model = new HomeIndexModelView()
            {
                slider = slider,
                sliderItems = sliderItems,
                videoSection = videoSection,
                videoSectionItems = videoSectionItems
            };
            return View(model);
        }
    }
}
