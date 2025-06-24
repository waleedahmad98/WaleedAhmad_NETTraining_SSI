using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Training_Day1.Models;
using Training_Day1.Services;

class Program
{
    static void Main()
    {
        // 1. Build configuration
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // Important for Console apps
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();


        var services = new ServiceCollection();
        services.Configure<AppOptions>(config.GetSection("AppOptions"));
        services.AddSingleton<ILibraryService, LibraryService>();
        services.AddTransient<Runner>();

        var provider = services.BuildServiceProvider();

        
        var runner = provider.GetRequiredService<Runner>();
        runner.Run();

    }
}