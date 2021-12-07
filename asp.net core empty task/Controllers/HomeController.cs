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
            List<Category> categories = _context.Categories.ToList();
            List<Product> products = _context.Products.ToList();
            Subscription subscription = _context.Subscription.FirstOrDefault();

            Experts experts = _context.Experts.FirstOrDefault();
            List<ExpertItem> expertItems = _context.ExpertItems.ToList();

            HomeIndexModelView model = new HomeIndexModelView()
            {
                slider = slider,
                sliderItems = sliderItems,
                videoSection = videoSection,
                videoSectionItems = videoSectionItems,
                categories = categories,
                products = products,
                subscription = subscription,
                experts = experts,
                expertItems = expertItems
            };
            return View(model);
        }
    }
}
