using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace asp.net_core_empty_task.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            Footer model = _context.Footer.FirstOrDefault();
            return View(model);
        }
    }
}
