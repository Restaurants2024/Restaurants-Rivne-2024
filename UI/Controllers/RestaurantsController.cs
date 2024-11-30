using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class RestaurantsController : Controller
    {
        public RestaurantsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Restaurant1()
        {
            return View();
        }
        public IActionResult Restaurant2()
        {
            return View();
        }
        public IActionResult Restaurant3()
        {
            return View();
        }
        public IActionResult Restaurant4()
        {
            return View();
        }
        public IActionResult Restaurant5()
        {
            return View();
        }
    }
}