using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Day1.Models;

namespace Training_Day1.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly List<User> _users = new List<User>();
        private readonly List<Tuple<User, Book>> _borrowings = new List<Tuple<User, Book>>();
        
        public void AddUser(string email, string name, string gender)
        {
            _users.Add(new User(email, name, gender));
        }

        public List<User> GetUsers()
        {
            return _users.ToList();
        }

        public void AddBook(string isbn, string name, int quantity)
        {
            _books.Add(new Book(isbn, name, quantity));
        }

        public void UpdateBookQuantity(string isbn, int quantity)
        {
            var book = _books.FirstOrDefault(s => s.Isbn.Equals(isbn));
            if (book != null)
            {
                book.Quantity = quantity;
            }
        }

        public List<Book> GetBooks()
        {
            return _books.ToList();
        }

        public bool BorrowBook(string email, string isbn)
        {
            var users = GetUsers().FirstOrDefault(s => s.Email.Equals(email));
            var books = GetBooks().FirstOrDefault(s => s.Isbn.Equals(isbn) && s.Quantity > 0);

            if (books == null || users == null)
            {
                return false;
            }

            _borrowings.Add(new Tuple<User, Book>(users, books));
            books.Quantity -= 1;
            return true;

        }
    }
}
