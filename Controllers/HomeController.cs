using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using WWWROOT.Models;

namespace WWWROOT.Controllers
{
    public class HomeController : Controller
    {

      IConfiguration _config { get; }
      IHostingEnvironment _hosting { get; }

      public HomeController(IConfiguration config, IHostingEnvironment hosting)
      {
        _config = config;
        _hosting = hosting;
      }

        public IActionResult Index()
        {
          return View();
        }

        public IActionResult About()
        {
          ViewData["Message"] = "Your application description page.";

          @ViewBag.EnvironmentName = _hosting.EnvironmentName;

          string sLoggingLevel = _config.GetValue<string>("Logging:LogLevel:Default");
          @ViewBag.LogLevel = sLoggingLevel;

          string sSecretTest = _config["ConnectionString_Portal"];
          @ViewBag.ConnectionString_Portal = sSecretTest;
          
          return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
