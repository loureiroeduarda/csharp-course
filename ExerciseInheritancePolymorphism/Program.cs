using System.Globalization;
using ExerciseInheritancePolymorphism.Entities;

namespace ExerciseInheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final, mostrar a etiqueta de preço de cada produto na
            mesma ordem em que foram digitados. Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e produtos usados
            possuem data de fabricação. Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo (próxima página). Para produtos
            importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.*/

            List<Product> productsList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberProduct = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberProduct; i++)
            {
                Console.WriteLine();
                Console.Write($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
                    productsList.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productsList.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    productsList.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}