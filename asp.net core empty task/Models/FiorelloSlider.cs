using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_empty_task.Models
{
    public class FiorelloSlider
    {
        public int id { get; set; }
        public string text { get; set; }

        List<FiorelloSliderItem> fiorelloSliderItems { get; set; }
    }
}
