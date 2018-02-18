using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WWWROOT.Models;

namespace WWWROOT.Controllers
{
    public class HomeController : Controller
    {

      IConfiguration _config { get; }

      public HomeController(IConfiguration config)
      {
        _config = config;
      }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

         
          string sLoggingLevel = _config.GetValue<string>("Logging:LogLevel:Default");

          @ViewBag.LogLevel = sLoggingLevel;

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
