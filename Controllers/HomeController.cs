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
            ViewBag.auth = true; //To see the logout button
            return View();
        }
        
        [AllowAnonymous]
        public ActionResult SignUp()
        {
            ViewBag.showLogIn = true; //To see the log in button
            return View();
        }

        [AllowAnonymous]
        public ActionResult LogIn()
        {
            ViewBag.showSignUp = true; //To see the sign up button
            return View();
        }        
        
        public ActionResult LogOut()
        {
            //We just redirect to the LogIn because the client side will
            //handle the log out action removing the session token
            return RedirectToAction("LogIn");
        }
    }
}