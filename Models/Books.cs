using System;
using System.ComponentModel.DataAnnotations;

namespace WWWROOT.Models
{

  public class Books
  {
    [Key]
    public int BookId {get;set;}

    public string BookTitle {get;set;}

    public int PublishYear {get;set;}

  }



}