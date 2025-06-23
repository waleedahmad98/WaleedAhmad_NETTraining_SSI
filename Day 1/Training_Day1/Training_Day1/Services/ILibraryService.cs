using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Day1.Models;

namespace Training_Day1.Services
{
    internal interface ILibraryService
    {
        public void AddUser(string email, string name, string gender);
        public List<User> GetUsers();
        public void AddBook(string isbn, string name, int quantity);
        public void UpdateBookQuantity(string isbn, int quantity);
        public List<Book> GetBooks();
        public bool BorrowBook(string email, string isbn);

    }
}
