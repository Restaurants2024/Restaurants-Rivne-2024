using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class AlbumController : Controller
    {
        public AlbumController()
        {
        }
        public IActionResult index()
        {
            return View();
        }
        public IActionResult AlbumFood()
        {
            return View();
        }
        public IActionResult AlbumDesserts()
        {
            return View();
        }
        public IActionResult AlbumDrinks()
        {
            return View();
        }
        public IActionResult AlbumLocation()
        {
            return View();
        }
        public IActionResult AlbumStaff()
        {
            return View();
        }

    }
}