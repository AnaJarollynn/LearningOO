using System.Globalization;
using TestProject3.Entities.Enum;

namespace TestProject3.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            return Items.Sum(x => x.SubTotal());
        }

        public override string ToString()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Product.Name}, ${item.Price.ToString("f2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            return "Total Price: " + Total().ToString("f2", CultureInfo.InvariantCulture);
        }


    }
}