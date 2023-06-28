using System.Globalization;

namespace ExerciseEmployee
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id)
        {
            Id = id;
        }
        public Employee(int id, string name, double salary) : this (id)
        {
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

        public bool EmployeeAlreadyRegistered(List<Employee> employeeList)
        {
            foreach (Employee employeeRegistered in employeeList)
            {
                if (employeeRegistered.Id == employeeRegistered.Id)
                {
                    return true;
                }
            }
            return false;
        }

        override public string ToString()
        {
            return Id + ", " + Name + ", R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}