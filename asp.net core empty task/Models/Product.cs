namespace asp.net_core_empty_task.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
