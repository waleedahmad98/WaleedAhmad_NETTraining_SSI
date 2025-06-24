using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Training_Day1.Models;

namespace Training_Day1.Services
{
    public class Runner
    {
        private readonly ILibraryService _libraryService;
        private readonly AppOptions _options;

        public Runner(ILibraryService libraryService, IOptions<AppOptions> options)
        {
            _libraryService = libraryService;
            _options = options.Value;
        }

        public void Run()
        {

            Console.WriteLine($"{_options.AppName} - {_options.Version}");

            _libraryService.AddBook("123", "MyBook", 3);
            _libraryService.AddUser("user@email", "MyUser", "M");

            Console.WriteLine("Books in Library:");
            foreach (var book in _libraryService.GetBooks())
                Console.WriteLine($"{book.Isbn} - {book.Name} - {book.Quantity}");

            _libraryService.BorrowBook("user@email", "123");

            foreach (var book in _libraryService.GetBooks())
                Console.WriteLine($"{book.Isbn} - {book.Name} - {book.Quantity}");

            Console.ReadLine();

        }
    }
}
