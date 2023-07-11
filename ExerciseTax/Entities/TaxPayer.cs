using System.Globalization;

namespace ExerciseTax.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        override public string ToString()
        {
            return Name + ": R$ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}