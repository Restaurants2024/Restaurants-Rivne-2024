using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class FoodController : Controller
    {
        public FoodController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}