using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("livros")]

        public IActionResult GetAllUntypedBooks()
        {
            var books = Book.GetAllBooks();
            return Ok(books);
        }
    }
}