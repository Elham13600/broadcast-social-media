using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class BookViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public BookViewModel(Book book)
        {
            Id = book.Id.ToString();
            Title = book.Title;
        }
    }
}
