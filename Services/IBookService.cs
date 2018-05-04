// Book Service Interface
using System;
using System.Collections.Generic;
using WWWROOT.Models;

public interface IBookService
{

  List<Book> GetBooks();
  
  
}