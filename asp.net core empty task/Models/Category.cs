using System.Collections.Generic;

namespace asp.net_core_empty_task.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
