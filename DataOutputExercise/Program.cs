using System.Globalization;

namespace DataOutputExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double dimension = 53.234567;

            Console.WriteLine($"Produtos: \n{product1}, cujo preço é R$ {price1:F2} \n{product2}, cujo preço é R$ {price2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {dimension:F8}");
            Console.WriteLine($"Arredondamento (três casas decimais): {dimension:F3}");
            Console.WriteLine("Separador decimal invariant cultura: " + dimension.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

