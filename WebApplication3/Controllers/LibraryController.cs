using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services;
using WebApplication3.Models; 

namespace WebApplication3.Controllers
{
    public class LibraryController : Controller
    {
        private readonly BookService _bookService;
        private readonly UserProfileService _userProfileService;

        public LibraryController(BookService bookService, UserProfileService userProfileService)
        {
            _bookService = bookService;
            _userProfileService = userProfileService;
        }

        public IActionResult Index()
        {
            return View(); // Представлення для домашньої сторінки
        }

        public IActionResult Books()
        {
            var books = _bookService.GetBooks(); // Отримання списку книг
            return View(books); // Передача списку книг у представлення
        }

        public IActionResult Profile(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID cannot be null."); // Повертаємо помилку, якщо ID не задано
            }

            var userProfile = _userProfileService.GetUserProfile(id.Value); // Отримання профілю за ID
            if (userProfile == null)
            {
                return NotFound(); // Якщо профіль не знайдено
            }
            return View(userProfile); // Передача профілю у представлення
        }
    }
}

