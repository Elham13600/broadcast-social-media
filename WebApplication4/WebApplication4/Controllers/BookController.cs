using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet(Name = "GetBooks")]
        public async Task<IEnumerable<BookViewModel>> Get()
        {
            var db = new Database();
            var books = await db.GetBooks();

            var viewModel = new List <BookViewModel>();

            foreach (var book in books)
            {
                viewModel.Add(new BookViewModel(book));
            }

            return viewModel;
        }

        [HttpGet("{id}", Name = "GetBookbyId")]
        public async Task<BookViewModel> GetById(string id) 
        {
            var db = new Database();
            var book = await db.GetBook(id);

            var viewModel = new BookViewModel(book);

            return viewModel;
        }

        [HttpPost(Name = "PostBook")]
        public async Task<IActionResult> Post(string Title, int pages)
        {
            var db = new Database();
            await db.SaveBook(Title, pages);

            return Ok();
        }
    }
}
