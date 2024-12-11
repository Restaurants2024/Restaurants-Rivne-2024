using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Data;
using UI.Models;

namespace UI.Controllers
{
    public class RatingController : Controller
    {
        ApplicationDbContext _context;
        public RatingController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_context.Restaurants.ToList());
        }
        public IActionResult Details(int id)
        {

            var restaurant = _context.Restaurants.Find(id);

            _context.Feedbacks.ToList();

            _context.Users.ToList();

            return View(_context.Feedbacks.ToList());
        }
    }
}