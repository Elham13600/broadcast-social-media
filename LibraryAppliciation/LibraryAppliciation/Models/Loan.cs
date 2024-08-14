using MongoDB.Bson;

namespace LibraryAppliciation.Models
{
    public class Loan
    {
        public ObjectId Id { get; set; }
        public string BookId { get; set; }
        public string Name { get; set; }
    }
}
