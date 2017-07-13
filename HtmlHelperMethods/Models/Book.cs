using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelperMethods.Models
{

    public class Books
    {
        public List<Book> GetBooks (){
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Daniel Jr", Price = 10, CopiesSold = 100, Description = "Watotot", Availability = Availability.Pickup, Genre = Genre.Bibi, InStock = false, YearPublished = 2019 });
            books.Add(new Book { BookId = 2, Title = "Kambarage Nyerere", Price = 4510, CopiesSold = 1100, Description = "Baba wa taifa", Availability = Availability.Reseller, Genre = Genre.Biography, InStock = true, YearPublished = 1993 });
            books.Add(new Book { BookId = 3, Title = "Mtembea mjini", Price = 50, CopiesSold = 100, Description = "Watotot", Availability = Availability.Pickup, Genre = Genre.Bibi, InStock = false, YearPublished = 2019 });
            books.Add(new Book { BookId = 4, Title = "Wahenga", Price = 20, CopiesSold = 1100, Description = "Baba wa taifa", Availability = Availability.Reseller, Genre = Genre.HadithiOrodo, InStock = true, YearPublished = 2013 });
            books.Add(new Book { BookId = 5, Title = "Mwana wetu", Price = 50, CopiesSold = 100, Description = "Watotot", Availability = Availability.Pickup, Genre = Genre.Western, InStock = true, YearPublished = 2019 });
            books.Add(new Book { BookId = 6, Title = "Kipenzi cha uzembe", Price = 510, CopiesSold = 1100, Description = "Baba wa taifa", Availability = Availability.Delivery, Genre = Genre.Technical, InStock = true, YearPublished = 2016 });
            books.Add(new Book { BookId = 7, Title = "Ow gugugug", Price = 250, CopiesSold = 100, Description = "Watotot", Availability = Availability.Delivery, Genre = Genre.Bibi, InStock = true, YearPublished = 2015 });
            books.Add(new Book { BookId = 8, Title = "Namieseto", Price = 340, CopiesSold = 1100, Description = "Baba wa taifa", Availability = Availability.Pickup, Genre = Genre.Biography, InStock = true, YearPublished = 2007 });


            return books;

        }
    }
    public class Book
    {

        public int BookId { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int CopiesSold { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public Availability Availability { get; set; }


        [Required]
        public Genre? Genre { get; set; }

        public string Description { get; set; }
    }

    public enum Genre
    {
        HadithiOrodo,
        Western,
        Bibi,
        Technical,
        Biography
    }


    public enum Availability
    {
        Pickup,
        Delivery,
        Reseller
    }
}