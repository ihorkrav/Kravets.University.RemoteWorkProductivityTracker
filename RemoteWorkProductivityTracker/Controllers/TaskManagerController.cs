using Microsoft.AspNetCore.Mvc;
using RemoteWorkProductivityTracker.Areas.Identity.Data;

namespace RemoteWorkProductivityTracker.Controllers
{
    public class TaskManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create (string Titile)
        {
            TrackerTask task = new TrackerTask();
            task.Title = Titile;
            Tasks
            return View();
        }

        public IActionResult Update (int id)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    
    }
}
