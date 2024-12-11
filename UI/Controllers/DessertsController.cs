using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class DessertsController : Controller
    {
        public DessertsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}