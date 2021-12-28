using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_empty_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize()]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
