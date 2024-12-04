using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Data;
using UI.Models;

namespace UI.Controllers
{
    public class MapController : Controller
    {
        ApplicationDbContext _context;
        public MapController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var restaurants = _context.Restaurants
                .ToList();

            return View(restaurants);
        }
    }
}