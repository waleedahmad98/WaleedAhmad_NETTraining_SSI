using Training_Day1.Models;
using Training_Day1.Services;

class Program
{
    static void Main()
    {
        var service = new LibraryService();
        service.AddBook("123", "MyBook", 3);
        service.AddUser("user@email", "MyUser", "M");

        Console.WriteLine("Books in Library:");
        foreach (var book in service.GetBooks())
            Console.WriteLine($"{book.Isbn} - {book.Name} - {book.Quantity}");

        service.BorrowBook("user@email", "123");

        foreach (var book in service.GetBooks())
            Console.WriteLine($"{book.Isbn} - {book.Name} - {book.Quantity}");
    }
}