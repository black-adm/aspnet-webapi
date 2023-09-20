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
    }
}