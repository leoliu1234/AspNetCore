using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demo
{
    public class HomeController : Controller
    {
        private readonly IUserLogic _userLogic;
        private readonly ILogger _logger;

        public HomeController(
            IUserLogic userLogic,
            ILogger logger
            )
        {
            _userLogic = userLogic;
            _logger = logger;
        }

        public ActionResult Index()
        {
            _logger.LogError(1,null,"test");

            return View();
        }

        public ActionResult Test()
        {
            return Content(_userLogic.GetSenderName());
        }

    }
}