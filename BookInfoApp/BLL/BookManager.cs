using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookInfoApp.DAL;
using BookInfoApp.Model;

namespace BookInfoApp.BLL
{
    internal class BookManager
    {
        BookGateway aGateway = new BookGateway();

        public string Save(Book aBook)
        {
            string isIsbnExist = aGateway.IsIsbnExist(aBook.isbn);
            if (isIsbnExist == "false")
            {

                if (aGateway.Save(aBook) > 0)
                {
                    return "Saved successfully";
                }
                else
                {
                    return "Save failed";
                }
            }
            else
            {
                return "ISBN Exist";
            }
        }
        public List<Book> GetAllBooks()
        {
            return aGateway.GetAllBooks();
        }
    }
}