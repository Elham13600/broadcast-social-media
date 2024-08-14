using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Webaplication_1.Models;

namespace Webaplication_1.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            MongoClient dbClient = new MongoClient();
            var database = dbClient.GetDatabase("restaurant");
            var collection = database.GetCollection<Location>("locations");

            List<Location> locations = collection.Find(o => true).ToList();

            return View(locations);
        }

        public IActionResult CreateLocation(Location location)
        {
            MongoClient dbClient = new MongoClient();
            var database = dbClient.GetDatabase("restaurant");
            var collection = database.GetCollection<Location>("locations");

            collection.InsertOne(location);

            return Redirect("/Locations");
        }

        public IActionResult CreateLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Stockholm()
        {
            return View();
        }

        public IActionResult Uppsala() 
        {
            return View(); 
        }
    }
}
