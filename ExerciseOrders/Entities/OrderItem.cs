using System.Globalization;
using System.Text;

namespace ExerciseOrders.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal()
        {
            return Price * Quantity;
        }

        override public string ToString()
        {
            StringBuilder stringBuilderOrderItem = new StringBuilder();
            stringBuilderOrderItem.AppendLine("Order items:");
            stringBuilderOrderItem.Append(Product.Name + ", R$ " + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", Quantity: " + Quantity + ", Subtotal: R$ " + Subtotal().ToString("F2", CultureInfo.InvariantCulture));
            return stringBuilderOrderItem.ToString();
        }
    }
}