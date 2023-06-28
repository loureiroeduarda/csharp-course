using System.Globalization;

namespace ExerciseEmployee
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        override public string ToString()
        {
            return Id + ", " + Name + ", R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}