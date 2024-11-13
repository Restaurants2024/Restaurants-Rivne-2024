using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class ReservationtsController : Controller
    {
        public ReservationtsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}