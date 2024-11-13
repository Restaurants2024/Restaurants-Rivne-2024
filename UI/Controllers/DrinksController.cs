using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class DrinksController : Controller
    {
        public DrinksController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}