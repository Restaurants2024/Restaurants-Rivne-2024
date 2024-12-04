using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Data;
using UI.Models;

namespace UI.Controllers
{
    public class RestaurantsController : Controller
    {
		ApplicationDbContext _context;
		public RestaurantsController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var restaurants = _context.Restaurants.ToList();
				
			return View(restaurants);
		}
        public IActionResult Details(int id)
        {
            var restaurant = _context.Restaurants.Find(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }
       

    }
}