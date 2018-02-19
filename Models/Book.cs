using System;
using System.ComponentModel.DataAnnotations;

namespace WWWROOT.Models
{

  public class Book
  {
    [Key]
    public int BookId {get;set;}

    public string BookTitle {get;set;}

    public int PublishYear {get;set;}

  }



}