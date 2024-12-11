using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class MoreController : Controller
    {
        public MoreController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}