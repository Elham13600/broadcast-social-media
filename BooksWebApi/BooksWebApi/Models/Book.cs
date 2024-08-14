namespace BooksWebApi.Models
{
    public class Book
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}
