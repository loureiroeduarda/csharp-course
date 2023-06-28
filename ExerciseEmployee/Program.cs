﻿using System.ComponentModel;

namespace ExerciseEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler um id e o valor X.
            Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários.
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente.
            Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.*/

            List<Employee> employeeList = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int quantityEmployee = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quantityEmployee; i++)
            {
                Console.WriteLine($"Employee #{i + 1}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                id = Employee.ValidateRegistrationId(id);
                Employee employee = new Employee(id);
                if (!employee.EmployeeAlreadyRegistered(employeeList))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    employee = new Employee(id, name, salary);
                    employeeList.Add(employee);
                }
                else
                {
                    Console.WriteLine("Id already registered!!");
                }
            }

            // Console.WriteLine();
            // Console.Write("Enter the employee id that will have salary increase: ");
            // int registeredId = int.Parse(Console.ReadLine());

        }
    }

}