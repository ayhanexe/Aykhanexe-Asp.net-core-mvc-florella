using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using asp.net_core_empty_task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp.net_core_empty_task.ViewComponents
{
    public class FiorelloSliderViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public FiorelloSliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            FiorelloSliderModelView model = new FiorelloSliderModelView()
            {
                fiorelloSlider = _context.FiorelloSlider.FirstOrDefault(),
                fiorelloSliderItems = _context.FiorelloSliderItems.ToList()
            };
            return View(model);
        }
    }
}
