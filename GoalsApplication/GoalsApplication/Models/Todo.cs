using MongoDB.Bson;

namespace GoalsApplication.Models
{
    public class Todo
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
    }
}
