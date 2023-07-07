using System.Globalization;

namespace ExerciseInheritancePolymorphism
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string PriceTag()
        {
            return Name + " R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}