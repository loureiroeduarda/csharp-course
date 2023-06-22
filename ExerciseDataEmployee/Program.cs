namespace ExerciseDataEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário
            (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é 
            afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.*/

            Employee employee = new Employee();

            Console.WriteLine("Entre com o nome do funcionário: ");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Entre com o salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do imposto: ");
            employee.Tax = double.Parse(Console.ReadLine());

            

        }
    }
}