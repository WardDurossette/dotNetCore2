using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WWWROOT.Models
{
  
  public class BooksDbContext : DbContext
  {


    public DbSet<Book> Books { get;set; }


    public BooksDbContext(DbContextOptions options)
      :base(options)
    {
    }




  }



}


