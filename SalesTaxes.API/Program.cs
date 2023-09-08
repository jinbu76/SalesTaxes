namespace SalesTaxes.API;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logging => logging.AddConsole())
        .ConfigureAppConfiguration(config => config.AddEnvironmentVariables())
        .ConfigureWebHostDefaults(config => config.UseStartup<Startup>());
}