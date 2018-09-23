using System.Collections.Generic;
using BooksWeb.Entities;

namespace BooksWeb.Models
{

    public class BooksViewModel
    {

        public Book SearchEntity { get; set; }

        public List<Book> Books { get; set; }

        public BooksViewModel ()
        {
            SearchEntity = new Book();
            Books = new List<Book>();      
        }

    }

    



}