using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookInfoApp.Model;

namespace BookInfoApp.DAL
{
    class BookGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BookConString"].ConnectionString;

        public int Save(Book aBook)
        {
            SqlConnection aConnection = new SqlConnection(connectionString);


            string query = "INSERT INTO book_info VALUES ('" + aBook.isbn + "', '" + aBook.name + "', '" +
                          aBook.author + "')";

            SqlCommand aCommand = new SqlCommand(query, aConnection);


            string isEmailExist = IsIsbnExist(aBook.isbn);


            aConnection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();

            aConnection.Close();

            return rowAffected;

        }

        public string IsIsbnExist(string isbn)
        {

            string query = "SELECT * FROM book_info WHERE isbn ='" + isbn + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader reader = aCommand.ExecuteReader();

            Book aBook = new Book();

            if (reader.HasRows)
            {
                reader.Read();
                aBook.isbn= reader["isbn"].ToString();
                reader.Close();
                aConnection.Close();

                return "true";
            }
            else
            {
                reader.Close();
                aConnection.Close();
                return "false";

            }


        }
        List<Book> bookList = new List<Book>();
        public List<Book> GetAllBooks()
        {
            SqlConnection aConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM book_info";
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader reader = aCommand.ExecuteReader();

            while (reader.Read())
            {
                Book aBook = new Book();

                aBook.isbn = reader["isbn"].ToString();
                aBook.name = reader["name"].ToString();
                aBook.author = reader["author"].ToString();
               
                bookList.Add(aBook);
            }
            reader.Close();
            aConnection.Close();
            return bookList;
        }
    }
}
