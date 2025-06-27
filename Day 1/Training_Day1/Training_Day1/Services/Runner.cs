using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Day1.Models;

namespace Training_Day1.Services
{
    public class Runner
    {
        private readonly ILibraryService _service;
        private readonly AppOptions _options;

        public Runner(ILibraryService service, AppOptions options)
        {
            _service = service;
            _options = options;
        }

        public void Run()
        {
            // Deserialize  into list 
            _service.AddBook("123", "MyBook", 3);
            _service.AddUser("user@email", "MyUser", "M");

            Console.WriteLine("Books in Library:");
            foreach (var book in _service.GetBooks())
                Console.WriteLine($"{book.Isbn} - {book.Name} - {book.Quantity}");

            _service.BorrowBook("user@email", "123");

            foreach (var book in _service.GetBooks())
                Console.WriteLine($"{book.Isbn} - {book.Name} - {book.Quantity}");
        }
    }
}
