using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp.net_core_empty_task.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Burani Doldur brat!"), MaxLength(50, ErrorMessage = "50 den uzun ola bilmez")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "255 den uzun ola bilmez")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
