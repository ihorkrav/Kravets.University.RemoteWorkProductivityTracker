using Microsoft.AspNetCore.Mvc;

namespace RemoteWorkProductivityTracker.Controllers
{
    public class TaskManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
