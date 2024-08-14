using Amazon.SecurityToken.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Webaplication_1.Models;

namespace Webaplication_1.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderFood(Order order)
        {
			MongoClient dbClient = new MongoClient();
			var database = dbClient.GetDatabase("restaurant");
			var collection = database.GetCollection<Order>("orders");

            collection.InsertOne(order);

			return View(order);
        }

        public IActionResult ShowOrders() 
        {
			MongoClient dbClient = new MongoClient();
			var database = dbClient.GetDatabase("restaurant");
			var collection = database.GetCollection<Order>("orders");

            List<Order> orders = collection.Find(o => true).ToList();
			return View(orders);
        }

        public IActionResult ShowOrder(string Id)
        {
            ObjectId objectId = new ObjectId();
            MongoClient dbClient = new MongoClient();
            var database = dbClient.GetDatabase("restaurant");
            var collection = database.GetCollection<Order>("orders");

            Order order = collection.Find(o => o.Id == objectId).FirstOrDefault();

            return View(order);
        }

        [HttpPost]
        public IActionResult DeleteOrder(string Id)
        {
            ObjectId orderId = new ObjectId(Id);
            MongoClient dbClient = new MongoClient();
            var database = dbClient.GetDatabase("restaurant");
            var collection = database.GetCollection<Order>("orders");

            collection.DeleteOne(o => o.Id == orderId);

                return Redirect("/Order/ShowOrders");

        }
    }
}
