using LibraryAppliciation.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LibraryAppliciation.Controllers
{
    public class LoansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() 
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Book>("books");

            List<Book> books = collection.Find(b => true).ToList();

            return View(books);
        }

        [HttpPost]
        public IActionResult Create(Loan loan)
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Loan>("loans");
            collection.InsertOne(loan);

            return Redirect("/Loans");
        }
    }
}
