using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}