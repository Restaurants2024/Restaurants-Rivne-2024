using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [AllowAnonymous]
        public IActionResult Index()
		{
			var restaurants = _context.Restaurants.OrderBy(r => r.Title).ToList();
				
			return View(restaurants);
          

        }
        public IActionResult Details(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["ErrorMessage"] = "Ви повинні увійти або зареєструватися, щоб переглянути цю сторінку.";
                return Redirect(Url.Content("~/Identity/Account/Register"));
                // Перенаправлення на реєстрацію
            }

            var restaurant = _context.Restaurants
                             .Include(r => r.Bookings)
                             .Include(r => r.Feedbacks)
                             .FirstOrDefault(r => r.Id == id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);


        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null) return NotFound();

            return View(restaurant);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Restaurant restaurant)
        {
            if (id != restaurant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurant);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Ресторан успішно оновлений!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Помилка оновлення ресторану: {ex.Message}");
                }
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"Model error: {error.ErrorMessage}");
            }

            return View(restaurant);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Restaurant restaurant, IFormFile photo)
        {
            if (photo != null)
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
                var extension = Path.GetExtension(photo.FileName).ToLower();
                if (!allowedExtensions.Contains(extension))
                {
                    ModelState.AddModelError("Photo", "Неприпустимий формат файлу.");
                }
                else if (photo.Length > 10485760) // 10 MB
                {
                    ModelState.AddModelError("Photo", "Розмір файлу перевищує 10 MB.");
                }
            }

            if (ModelState.IsValid)
            {
                if (photo != null && photo.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await photo.CopyToAsync(memoryStream);
                        restaurant.Photo = memoryStream.ToArray();
                    }
                }

                try
                {
                    _context.Add(restaurant);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Ресторан успішно доданий!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Помилка при додаванні ресторану: " + ex.Message);
                }
            }

            return View(restaurant);
        }





        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                _context.Restaurants.Remove(restaurant);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}