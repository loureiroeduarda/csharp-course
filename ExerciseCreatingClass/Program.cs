using System.Globalization;

namespace ExerciseCreatingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // ShowOlderPerson();
            CalculateAverageSalary();
        }

        public static void ShowOlderPerson()
        {
            /*Exercício 01: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.*/

            Person person1 = new Person();
            Person person2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            person1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            person1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            person2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            person2.Age = int.Parse(Console.ReadLine());

            if (person1.Age > person2.Age)
            {
                Console.WriteLine("A pessoa mais velha é: " + person1.Name);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + person2.Name);
            }
        }

        public static void CalculateAverageSalary()
        {
            /*Exercício 02: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.*/

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.Salary = double.Parse(Console.ReadLine());

            double average = (employee1.Salary + employee2.Salary) / 2.0;

            Console.WriteLine("O salário médio é: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

