using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using asp.net_core_empty_task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp.net_core_empty_task.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            Blog blog = _context.Blog.FirstOrDefault();
            List<BlogItem> blogItems = _context.BlogItems.ToList();

            BlogViewModel model = new BlogViewModel
            {
                blog = blog,
                blogItems = blogItems
            };

            return View(model);
        }
    }
}
