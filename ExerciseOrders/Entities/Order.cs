using System.Globalization;
using System.Text;
using ExerciseOrders.Entities.Enums;

namespace ExerciseOrders.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
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

        public double TotalOrder()
        {
            double totalOrder = 0;
            foreach (OrderItem item in Items)
            {
                totalOrder += totalOrder + item.Subtotal();
            }
            return totalOrder;
        }

        override public string ToString()
        {
            StringBuilder stringBuilderOrder = new StringBuilder();
            stringBuilderOrder.Append("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-BR")));
            stringBuilderOrder.Append("Order status: " + Status);
            stringBuilderOrder.Append("Client: " + Client);
            return stringBuilderOrder.ToString();
        }
    }
}