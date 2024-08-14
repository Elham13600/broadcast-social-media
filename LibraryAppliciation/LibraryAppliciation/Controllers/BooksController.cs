using LibraryAppliciation.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryAppliciation.Controllers
{
    public class BooksController : Controller
    {
        public byte[] Id { get; private set; }

        public IActionResult Index()
        {

            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Book>("books");

            List<Book>books =collection.Find(b => true).ToList();

            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Creat(Book book)
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Book>("books");
            collection.InsertOne(book);

            return Redirect("/Books");
        }

        public IActionResult Show(string Id) 
        {
            ObjectId bookId = new ObjectId(Id);

            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Book>("books");

            Book book = collection.Find(b => b.Id == bookId).FirstOrDefault();

            return View(book);
        }

        public IActionResult Edit(string Id)
        {
            ObjectId bookId = new ObjectId(Id);

            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Book>("books");

            Book book = collection.Find(b => b.Id == bookId).FirstOrDefault();

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(string id, Book book) 
        {
            ObjectId bookId = new ObjectId(Id);

            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("library_application");
            var collection = database.GetCollection<Book>("books");

            book.Id = bookId;
            collection.ReplaceOne(b => b.Id == bookId , book);

            return Redirect("/Books");
        }
    }
}
