using asp.net_core_empty_task.Models;
using System.Collections.Generic;

namespace asp.net_core_empty_task.ViewModels
{
    public class HomeIndexModelView
    {
        public Slider slider { get; set; }
        public List<SliderItem> sliderItems { get; set; }
        public VideoSection videoSection { get; set; }
        public List<VideoSectionItem> videoSectionItems { get; set; }
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
        public Subscription subscription { get; set; }
        public Experts experts { get; set; }
        public List<ExpertItem> expertItems { get; set; }
    }
}
