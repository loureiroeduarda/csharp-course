using System.Globalization;

namespace ExerciseEmployee
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public static int ValidateRegistrationId(int id)
        {
            while (id < 100 || id > 999)
            {
                Console.WriteLine("Invalid option! Try again!!");
                id = int.Parse(Console.ReadLine());
            }
            return id;
        }

        override public string ToString()
        {
            return Id + ", " + Name + ", R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}