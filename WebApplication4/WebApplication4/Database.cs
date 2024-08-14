using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using MongoDB.Bson;
using MongoDB.Driver;
using WebApplication4.Models;

namespace WebApplication4
{
    public class Database
    {
        private IMongoDatabase GetDB() 
        { 
        MongoClient client = new MongoClient();
            var DB = client.GetDatabase("BooksDB");
            return DB;
        }

        public async Task<List<Book>> GetBooks()
        {
            var books = await GetDB().GetCollection<Book>("Books")
            .Find(b => true)
                .ToListAsync();
            return books;
        }

        public async Task<Book> GetBook(string id)
        {
            ObjectId _Id = new ObjectId(id);

            var book = await GetDB().GetCollection<Book>("Books")
                .Find(b => b.Id == _Id)
                .SingleOrDefaultAsync();

            return book;
        }

        public async Task SaveBook(string title, int pages)
        {
            var book = new Book()
            {
                Title = title,
                Pages = pages
            };

            await GetDB().GetCollection<Book>("Books")
                .InsertOneAsync(book);
        }
    }
}
