using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class RatingController : Controller
    {
        public RatingController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}