using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika.WebUI
{
    public class Program
    {
        public static void Main(string[] args) //Program buradan ba?lar.
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
                //Postu create ederken buradaki klaslardaki ayarlar? kullan diyor.
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
