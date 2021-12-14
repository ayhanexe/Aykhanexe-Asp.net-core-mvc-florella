using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_empty_task.Models
{
    public class FiorelloSliderItem
    {
        public int id { get; set; }
        public string imageUrl { get; set; }

        FiorelloSlider fiorelloSlider { get; set; }
    }
}
