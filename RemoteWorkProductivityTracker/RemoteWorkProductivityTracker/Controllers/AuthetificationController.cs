using Microsoft.AspNetCore.Identity.UI.V5.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;

namespace RemoteWorkProductivityTracker.Controllers
{
    public class AuthetificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult LogIn()
        //{
        //    return View("~Areas/Identity/Pages/Account/Login.cshtml");
        //}
        //public IActionResult LogInForm()
        //{
        //    var model = new LoginModel();
        //    return PartialView("_LoginPartial", model);
        //}
        
    }
}
