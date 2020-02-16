using System.Web.Mvc;

namespace BelfastWF_bkend.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return RedirectToAction("LogIn");
        }
        
        [AllowAnonymous]
        public ActionResult weatherForecast()
        {
            if (!Request.IsAuthenticated)
            {
                return RedirectToAction("LogIn");
            }
            return View();
        }
        
        [AllowAnonymous]
        public ActionResult SignUp()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("weatherForecast");
            }

            ViewBag.showLogIn = true;
            return View();
        }

        [AllowAnonymous]
        public ActionResult LogIn()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("weatherForecast");
            }

            ViewBag.showSignUp = true;
            return View();
        }
    }
}