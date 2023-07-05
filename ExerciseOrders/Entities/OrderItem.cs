namespace ExerciseOrders.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> product { get; set; } = new List<Product>();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double Subtotal(double quantity, double price)
        {
            return price * quantity;
        }
    }
}