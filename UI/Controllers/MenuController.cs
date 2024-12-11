using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class MenuController : Controller
    {
        public MenuController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}