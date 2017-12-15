using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            return View();
        }

        public ActionResult Test()
        {
            return Content(_userLogic.GetSenderName());
        }

    }
}