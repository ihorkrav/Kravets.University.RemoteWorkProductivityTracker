using Microsoft.AspNetCore.Mvc;

namespace RemoteWorkProductivityTracker.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
