using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using AppSettingsLoader.OldConfiguration;

namespace AppSettingsLoader.Dump
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration(config =>
            {
                config.Sources.Clear();

                config.AddAppSettingsFromWebConfig();
            }).UseStartup<Startup>();
    }
}