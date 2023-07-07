using System.Globalization;

namespace ExerciseInheritancePolymorphism.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: R$ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}