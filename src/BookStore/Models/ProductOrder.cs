using System.Collections.Generic;

namespace BookStore.Models
{
    public class ProductOrder
    {
        public ProductOrder(int id, int quantity)
        {
            Id = id;
            Quantity = quantity;

            foreach (var item in Products)
            {
                Total += item.Price;
            }

            Total *= Quantity;
        }

        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal Total { get; private set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual Order Order { get; set; }
    }
}