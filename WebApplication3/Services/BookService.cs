using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class BookService
    {
        public List<Book> GetBooks()
        {
            // Повертаємо список книг (приклад)
            return new List<Book>
        {
            new Book { Title = "1984", Author = "George Orwell" },
            new Book { Title = "The Road", Author = "Jack London" }
        };
        }
    }


}
