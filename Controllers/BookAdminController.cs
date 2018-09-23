using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BooksWeb.Entities;
using BooksWeb.Models;

namespace BooksWeb.Controllers
{

  public class BookAdminController : Controller
  {

    // Class member variables and properties
    IConfiguration _config { get; }

    private readonly BooksDbContext _dbContext;

    public BookAdminController(IConfiguration config, BooksDbContext context)
    {
      _config = config;
      _dbContext = context;
    }


    public IActionResult Index()
    {

      List<Book> books = _dbContext.Books.ToList();
      Book SearchEntity = new Book();

      BooksViewModel vm = new BooksViewModel();
      vm.SearchEntity = SearchEntity;
      vm.Books = books;

      return View(vm);

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