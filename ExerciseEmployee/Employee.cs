using System.Globalization;

namespace ExerciseEmployee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double IncreaseSalary(double percentage)
        {
            return Salary += Salary * (percentage / 100);
        }
        override public string ToString()
        {
            return Id + ", " + Name + ", R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}