using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BooksWeb.Entities
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


