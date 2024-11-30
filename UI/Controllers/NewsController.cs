using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class NewsController : Controller
    {
        public NewsController()
        {
        }
        public IActionResult index()
        {
            return View();
        }
        public IActionResult NewsFood()
        {
            return View();
        }
        public IActionResult NewsDesserts()
        {
            return View();
        }
        public IActionResult NewsDrinks()
        {
            return View();
        }
        public IActionResult NewsLocation()
        {
            return View();
        }
        public IActionResult NewsStaff()
        {
            return View();
        }

    }
}