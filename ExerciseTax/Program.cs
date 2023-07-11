using System.Globalization;
using ExerciseTax.Entities;

namespace ExerciseTax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais podem ser pessoa física ou pessoa jurídica,
            e depois mostrar o valor do imposto pago por cada um, bem como o total de imposto arrecadado. 
            Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica são nome, renda anual e número de funcionários.
            As regras para cálculo de imposto são as seguintes:
            Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com renda de 20000.00 em diante pagam 25% de imposto.
            Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto. 
            Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica: (50000 * 25%) - (2000 * 50%) = 11500.00
            Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10 funcionários, ela paga 14% de imposto. 
            Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 
            400000 * 14% = 56000.00*/

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numberTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberTaxPayers; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char chosenPayerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (chosenPayerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
            }
        }
    }
}