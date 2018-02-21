using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WWWROOT
{
  public class Program
  {
    public static void Main(string[] args)
    {
        BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
      WebHost.CreateDefaultBuilder(args)
        
      .UseContentRoot(Directory.GetCurrentDirectory())
          

      .ConfigureAppConfiguration((builderContext, config) => {
        IHostingEnvironment env = builderContext.HostingEnvironment;

        // First we load appsettings, overloaded by appsettings.EnvironmentName
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
          
        // If we are dev, use the usersecrets
        if (env.IsDevelopment())
        {
            config.AddUserSecrets<Startup>();
        }
        // Environment variables trump all others
        config.AddEnvironmentVariables();
      })
      .UseStartup<Startup>()
      .Build();
  }
}
