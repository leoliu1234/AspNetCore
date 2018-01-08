using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLogicLayer.Logics;

namespace demo
{
    public class HomeController : Controller
    {
        private readonly IUserLogic _userLogic;
        private readonly ILogger _logger;

        public HomeController(
            IUserLogic userLogic
            )
        {
            _userLogic = userLogic;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "leo";
            return View();
        }

        public ActionResult Test()
        {
            return Content(_userLogic.GetSenderName());
        }

    }
}