using asp.net_core_empty_task.Models;
using System.Collections.Generic;

namespace asp.net_core_empty_task.ViewModels
{
    public class BlogViewModel
    {
        public Blog blog { get; set; }
        public List<BlogItem> blogItems { get; set; }
    }
}
