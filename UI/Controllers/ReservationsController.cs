using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class ReservationsController : Controller
    {
        public ReservationsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}