using System.Globalization;

namespace ExerciseStaticLimbs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
            Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre
            o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.*/

            Console.Write("Qual é a cotação do dólar? ");
            double DollarExchangeRate = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double DollarAmount = double.Parse(Console.ReadLine());

            double tax = CurrencyConverter.CalculateTax(DollarExchangeRate, DollarAmount);
            Console.WriteLine("O valor do imposto a ser pago é: R$ " + tax.ToString("F2"), CultureInfo.InvariantCulture);

            double realValue = CurrencyConverter.CalculateTotalPaidReal(DollarExchangeRate, DollarAmount);
            Console.WriteLine("O valor total a ser pago em reais é: R$ " + realValue.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}