using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Http;

namespace asp.net_core_empty_task.Areas.Admin.ViewModels
{
    public class SliderMultipleViewModel
    {
        public IFormFile[] sliderItems { get; set; }
    }
}
