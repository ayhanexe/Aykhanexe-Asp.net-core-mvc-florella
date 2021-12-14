using asp.net_core_empty_task.Models;
using System.Collections.Generic;

namespace asp.net_core_empty_task.ViewModels
{
    public class FiorelloSliderModelView
    {
        public FiorelloSlider fiorelloSlider { get; set; }
        public List<FiorelloSliderItem> fiorelloSliderItems { get; set; }
    }
}
