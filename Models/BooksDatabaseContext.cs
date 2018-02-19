using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WWWROOT.Models
{
  
  public class BooksDBContext : DbContext
  {
    
    public DbSet<Book> Books { get;set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

      optionsBuilder.UseSqlite("Filename=./BooksWeb.db");

    }


  }



}


