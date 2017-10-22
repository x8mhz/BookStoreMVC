using System;

namespace BookStore.Models
{
    public class Order
    {
        public Order(int id, DateTime orderDate, DateTime sendDate)
        {
            Id = id;
            OrderDate = DateTime.Now;
            SendDate = orderDate.AddDays(2); //Exemple
            DeliveryDate = sendDate.AddDays(9); //Exemple
        }

        public int Id { get; private set; }
        public DateTime OrderDate { get; private set; }
        public DateTime SendDate { get; set; }
        public DateTime DeliveryDate { get; private set; }

        public virtual User User { get; private set; }
        public virtual ProductOrder ProductOrder { get; private set; }

    }
}