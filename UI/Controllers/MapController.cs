using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class MapController : Controller
    {
        public MapController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}