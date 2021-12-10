using System;

namespace asp.net_core_empty_task.Models
{
    public class BlogItem
    {
        public int id { get; set; }
        public string image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
