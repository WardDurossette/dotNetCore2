using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BooksWeb.Entities;

namespace BooksWeb.Controllers
{


  public class BookAPIController : Controller
  {

    // Class member variables and properties
    IConfiguration _config { get; }

    private readonly BooksDbContext _dbContext;

    public BookAPIController(IConfiguration config, BooksDbContext context)
    {
      _config = config;
      _dbContext = context;
    }


    [HttpGet("api/bookapi")]
    public JsonResult GetAllBooks()
    {

      List<Book> books = _dbContext.Books.ToList();

      return new JsonResult(books);

    }

    public JsonResult Details(int? Id)
    {
      if (Id == null)
      {
        return new JsonResult(null);
      }

      var book = _dbContext.Books.SingleOrDefault(m => m.BookId == Id);
      if (book == null)
      {
        return new JsonResult(null);
      }
      return new JsonResult(book);
    }



  }

}