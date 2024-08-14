using System.Data.SqlClient;
using BooksWebApi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace BooksWebApi
{
    public class DBConnection
    {
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            var cmd = GetSqlCommand();

            cmd.CommandText = "SELLECT * FROM Books";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var book = new Book()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Title = reader["Title"].ToString(),
                    Pages = int.Parse( reader["Pages"].ToString()),
                };
                books.Add(book);
            }

            return books;
        }

        public Book GetBookById(int id) 
        {
            var cmd = GetSqlCommand();

            cmd.CommandText = "SELLECT * FROM Books WHERE Id = @Id";

            cmd.Parameters.AddWithValue("id", id);
            
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var book = new Book()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Title = reader["Title"].ToString(),
                    Pages = int.Parse(reader["Pages"].ToString()),
                };
                return book;
            }

            return null;
        }

        private SqlCommand GetSqlCommand() 
        {
            string connectionstring = "Data Source=localhost;initial Catolog=BooksDB; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionstring);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            return cmd;
        }
    }
}
