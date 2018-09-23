using System;
using System.ComponentModel.DataAnnotations;

namespace BooksWeb.Entities
{

  public class Book
  {
    [Key]
    public int BookId {get;set;}

    public string BookTitle {get;set;}

    public int PublishYear {get;set;}

  }



}