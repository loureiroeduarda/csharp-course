using System.Data;
using System.Globalization;
using ExerciseOrders.Entities;
using ExerciseOrders.Entities.Enums;

namespace ExerciseOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um sumário do pedido.
            Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now*/

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int numberItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberItems; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantityProduct, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}