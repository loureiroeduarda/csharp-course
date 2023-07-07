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

        public override string PriceTag()
        {
            return base.PriceTag() + "(Customs fee: R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}