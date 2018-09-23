// Book Service Interface
using System;
using System.Collections.Generic;
using BooksWeb.Entities;

public interface IBookService
{

  List<Book> GetBooks();
  
  
}