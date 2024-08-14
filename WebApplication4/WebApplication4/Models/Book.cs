using MongoDB.Bson;

namespace WebApplication4.Models
{
    public class Book
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}
