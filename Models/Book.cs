using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Activate { get; set; }

        public Book()
        {
            CreationDate = DateTime.Now;
            Activate = true;
        }

        public Book(int id, string title, string author, string category, int quantity, decimal price)
        {
            ID = id;
            Title = title;
            Author = author;
            Category = category;
            Quantity = quantity;
            Price = price;
        }

        public void Disable() =>
            Activate = false;

        public static IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>
             {
                new Book(1, "Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans", "Software", 26, 59.90m),
                new Book(2, "Agile Principles, Patterns, and Practices in C#", "Robert C. Martin", "Software", 13, 45.90m),
                new Book(3, "Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", "Software", 10, 33.90m),
                new Book(4, "Implementing Domain-Driven Design", "Vaughn Vernon", "Software", 22, 59.90m),
                new Book(5, "Patterns, Principles, and Practices of Domain-Driven Design", "Scott Millet", "Software", 15, 42.90m),
                new Book(6, "Refactoring: Improving the Design of Existing Code", "Martin Fowler", "Software", 5, 31.90m)
            };
        }

        public static Book GetBook(int id)
        {
            return GetAllBooks()
                .FirstOrDefault(book => book.ID == id);
        }
    }
}