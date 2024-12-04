using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Data;
using UI.Models;

namespace UI.Controllers
{
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var newsList = _context.News.ToList();
            return View(newsList);
        }
		public IActionResult Details(int id)
		{
			var newsItem = _context.News.FirstOrDefault(n => n.Id == id);
			if (newsItem == null)
			{
				return NotFound();
			}

			// Логіка відображення фото
			ViewData["ShowPhoto"] = id <= 2; // Показуємо фото лише для перших двох сторінок
			ViewData["SmallPhoto"] = (id == 1 || id == 2 || id == 5); // Встановлюємо розмір фото для 1, 2 та 5 сторінок

			return View(newsItem);
		}






		public IActionResult NewsFood()
        {
            return View();
        }
        public IActionResult NewsDesserts()
        {
            return View();
        }
        public IActionResult NewsDrinks()
        {
            return View();
        }
        public IActionResult NewsLocation()
        {
            return View();
        }
        public IActionResult NewsStaff()
        {
            return View();
        }

    }
}