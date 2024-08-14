using MongoDB.Bson;

namespace LibraryAppliciation.Models
{
    public class Book
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
    }
}
