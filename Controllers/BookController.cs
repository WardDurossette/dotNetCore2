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

  public class BookController : Controller
  {

    // Class member variables and properties
    IConfiguration _config { get; }

    private readonly BooksDbContext _dbContext;

    public BookController(IConfiguration config, BooksDbContext context)
    {
      _config = config;
      _dbContext = context;
    }


    public IActionResult Index()
    {

      List<Book> books = _dbContext.Books.ToList();

      return View(books);

    }

    public IActionResult Details(int? Id)
    {
      if (Id == null)
      {
        return NotFound();
      }

      var book = _dbContext.Books.SingleOrDefault(m => m.BookId == Id);
      if (book == null)
      {
        return NotFound();
      }
      return View(book);
    }


    [HttpGet]
    public IActionResult Edit(int? Id)
    {
      if (Id == null)
      {
        return NotFound();
      }

      var book = _dbContext.Books.SingleOrDefault(m => m.BookId == Id);
      if (book == null)
      {
        return NotFound();
      }
      return View(book);
    }





  }

}