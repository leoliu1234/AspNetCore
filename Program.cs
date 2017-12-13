using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .CaptureStartupErrors(true)
            // .UseContentRoot("wwwroot")
            .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
            .UseEnvironment("Development")
            .UseUrls("http://localhost:8000;http://localhost:5000;")
            .UseShutdownTimeout(TimeSpan.FromSeconds(10))
            .UseWebRoot("wwwroot/public")
            .Build();
        }
    }
}
