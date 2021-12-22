using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_empty_task.Models
{
    public class SliderItem
    {
        public int id { get; set; }
        public string image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        [ForeignKey("sliderId")]
        public Slider slider { get; set; }
    }
}
