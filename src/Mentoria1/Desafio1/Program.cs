using System.Linq;
using Desafio1.Util;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Desafio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Descomentar apenas se for fazer o desafio extra \/
            // Log.Logger = new LoggerConfiguration()
            //     .ReadFrom.Configuration("<IConfiguration aqui>")
            //     .WriteTo.Console()
            //     .CreateLogger();
            // Helper.LogExtraSerilog();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // .UseSerilog() // Descomentar apenas se for fazer o desafio extra
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
