using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp.net_core_empty_task.ViewComponents
{
    public class SayViewComponent : ViewComponent
    {

        private AppDbContext _context;

        public SayViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<Say> model = _context.SayItems.ToList();

            return View(model);
        }
    }
}
