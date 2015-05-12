using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookInfoApp.BLL;
using BookInfoApp.DAL;
using BookInfoApp.Model;

namespace BookInfoApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
            ShowAllBook();

        }

        BookManager aManager =new BookManager();
        BookGateway aGateway = new BookGateway();
        private List<Book> books = new List<Book>(); 
         
        private void saveButton_Click(object sender, EventArgs e)
        {
            Book aBook =new Book();

            aBook.isbn = isbnTextBox.Text;
            aBook.name = bookNameTextBox.Text;
            aBook.author = authorTextBox.Text;

            MessageBox.Show(aManager.Save(aBook));
            ShowAllBook();

        }

        private void bookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllBook();
        }

        private void ShowAllBook()
        {
            books.Clear();
            books = aManager.GetAllBooks();
           bookListView.Items.Clear();
            
            foreach (Book book in books)
            {
                ListViewItem item = new ListViewItem(book.isbn.ToString());
                item.SubItems.Add(book.name);
                item.SubItems.Add(book.author);
                
              bookListView.Items.Add(item);
            }
        }

        private void ClearTextBox()
        {
            bookNameTextBox.Text = String.Empty;
            isbnTextBox.Text = String.Empty;
            authorTextBox.Text = String.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            string searchName = searchNameTextBox.Text;
            bookListView.Items.Clear();

            foreach (Book book in books)
            {
                if (book.name.ToUpper().Contains(searchName) || book.name.ToLower().Contains(searchName) || book.name.Contains(searchName))
                {
                    ListViewItem item = new ListViewItem(book.isbn.ToString());
                    item.SubItems.Add(book.name);
                    item.SubItems.Add(book.author);

                    bookListView.Items.Add(item);
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Name not Found");
            }
        }
    }
}
