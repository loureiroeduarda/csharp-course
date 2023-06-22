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

        public void IncreaseSalary(double percentage)
        {
            GrossSalary += GrossSalary * (percentage / 100.00);
        }

        override public string ToString()
        {
            return Name + ", R$ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}