using GoalsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GoalsApplication.Controllers
{
    public class TodosController : Controller
    {
        public IActionResult Index()
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("goals_application");
            var collection = database.GetCollection<Todo>("todos");
            List<Todo> todos = collection.Find(g => true).ToList();

            return View(todos);
        }

        public IActionResult Create() 
        {
        return View();
        }

        [HttpPost]
        public IActionResult Create(Todo todo) 
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("goals_application");
            var collection = database.GetCollection<Todo>("todos");
            collection.InsertOne(todo);

            return Redirect("/Todos");
        }

        [HttpPost]
        public IActionResult Delete(string Id) 
        {
            ObjectId todoId = new ObjectId(Id);
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("goals_application");
            var collection = database.GetCollection<Todo>("todos");

            collection.DeleteOne(t => t.Id == todoId);

            return Redirect("/Todos");
        }
    }
}
