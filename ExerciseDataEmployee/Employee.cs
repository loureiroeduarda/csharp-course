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
            double convertPercentage = percentage / 100;
            double IncreaseValue = GrossSalary * convertPercentage;
            double SalaryWithIncrease = GrossSalary - Tax + IncreaseValue;
            Console.WriteLine();
            Console.Write("Dados atualizados: " + Name + ", R$ " + SalaryWithIncrease);
        }

        override public string ToString()
        {
            return "Funcionário: " + Name + ", R$ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}