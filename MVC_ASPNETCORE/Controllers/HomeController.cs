using Microsoft.AspNetCore.Mvc;
using MVC_ASPNETCORE.Models;
using System.Diagnostics;

namespace MVC_ASPNETCORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var firstUser = new User();
            //firstUser.UserNo = 1;
            //firstUser.UserName = "홍길동";

            var HongUser = new User
            {
                UserNo = 1,
                UserName = "홍길동"
            };

            //return View(HongUser);
            //ViewBag.User = HongUser;

            ViewData["User"] = HongUser;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}