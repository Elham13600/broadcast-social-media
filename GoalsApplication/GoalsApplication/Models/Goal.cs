using MongoDB.Bson;

namespace GoalsApplication.Models
{
    public class Goal
    {
        public ObjectId Id { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
