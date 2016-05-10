using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiTier.Service.Interfaces;

namespace MultiTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggerService _logger = null;
        private readonly IUserService _userService = null;
        public HomeController(ILoggerService logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        public ActionResult Index()
        {
            var a = _userService.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}