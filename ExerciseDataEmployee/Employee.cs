using System.Globalization;

namespace ExerciseDataEmployee
{
    public class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        override public string ToString()
        {
            return "Funcionário: " + Name + ", R$ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}