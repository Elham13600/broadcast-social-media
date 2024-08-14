using GoalsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace GoalsApplication.Controllers
{
    public class GoalsController : Controller
    {
        public IActionResult Index()
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("goals_application");
            var collection = database.GetCollection<Goal>("goals");
            List<Goal> goals = collection.Find(g => true).ToList();

            return View(goals);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Goal goal) 
        { 
        MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("goals_application");
            var collection = database.GetCollection<Goal>("goals");
            collection.InsertOne(goal);

            return Redirect("/Goals");
        }
    }
}
