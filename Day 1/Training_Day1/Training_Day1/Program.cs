using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Training_Day1.Models;
using Training_Day1.Services;

class Program
{
    static void Main()
    {
        // get config
        var config = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange:true)
            .Build();

        // set dependency injection
        var services = new ServiceCollection();
        services.AddSingleton<ILibraryService, LibraryService>();
        services.Configure<AppOptions>(config.GetSection("AppOptions"));

        // Runner.cs
        services.AddSingleton<Runner>();

        var provider = services.BuildServiceProvider();
        var ourRunner = provider.GetRequiredService<Runner>();

        ourRunner.Run();
    }
}