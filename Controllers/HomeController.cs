using Microsoft.AspNetCore.Mvc;

namespace demo
{
    public class HomeController : Controller
    {
        private readonly IUserLogic _userLogic;

        public HomeController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Test()
        {
            return Content(_userLogic.GetSenderName());
        }

    }
}