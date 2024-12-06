using Microsoft.AspNetCore.Mvc;
using UI.Data;
using UI.Models;
using Microsoft.EntityFrameworkCore;


public class FeedbacksController : Controller
{
    private readonly ApplicationDbContext _context;

    public FeedbacksController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Success()
    {
        return View();
    }

    [HttpPost]
    [HttpPost]
    public IActionResult Create(Feedback feedback)
    {
        if (ModelState.IsValid)
        {
            feedback.Date = DateTime.Now; // Додати поточну дату до відгуку
            _context.Feedbacks.Add(feedback); // Додати відгук у базу даних
            _context.SaveChanges(); // Зберегти зміни
            return RedirectToAction("Success"); // Перенаправлення на сторінку успіху
        }
        return View("Error"); // У разі помилки повернути сторінку помилки
    }


    [HttpGet]
    public IActionResult List()
    {
        var feedbacks = _context.Feedbacks.Include(f => f.Person).Include(f => f.Restaurant).ToList();
        return View(feedbacks);
    }
}
