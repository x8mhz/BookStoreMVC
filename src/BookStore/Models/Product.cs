namespace BookStore.Models
{
    public class Product
    {
        public Product(int id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public virtual Category Category { get; set; }
    }
}