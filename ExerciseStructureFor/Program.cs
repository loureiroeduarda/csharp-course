using System.Globalization;

namespace ExerciseStructureFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // OddNumberList();
            // ShowRangeValues();
            // CalculatesWeightedAverage();
            // DivideNumbers();
            // CalculateFactorial();
            // CalculatesDivisors();
            CalculateFrameCube();
        }

        public static void OddNumberList()
        {
            /*Exercício 01: Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
            X, se for o caso.*/

            Console.Write("Digite um número inteiro entre 1 a 1000: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }

        public static void ShowRangeValues()
        {
            /*Exercício 02: Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)*/

            Console.Write("Digite um número inteiro: ");
            int entryNumber = int.Parse(Console.ReadLine());

            int counterIn = 0;
            int counterOut = 0;
            for (int i = 1; i <= entryNumber; i++)
            {
                Console.Write($"Número #{i}: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                {
                    counterIn++;
                }
                else
                {
                    counterOut++;
                }
            }
            Console.WriteLine(counterIn + " in");
            Console.WriteLine(counterOut + " out");
        }

        public static void CalculatesWeightedAverage()
        {
            /*Exercício 03: Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores,
            sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.*/

            Console.Write("Digite um número inteiro: ");
            int entryNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entryNumber; i++)
            {
                Console.Write($"Número #{i}: ");
                string[] vector = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vector[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vector[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vector[2], CultureInfo.InvariantCulture);

                double weightedAverage = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(weightedAverage.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        public static void DivideNumbers()
        {
            /*Exercício 04: Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/

            Console.Write("Digite um número inteiro: ");
            int entryNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entryNumber; i++)
            {
                Console.Write($"Número #{i}: ");
                string[] vector = Console.ReadLine().Split(' ');
                int n1 = int.Parse(vector[0]);
                int n2 = int.Parse(vector[1]);

                if (n2 > 0 || n2 < 0)
                {
                    double divide = (double)n1 / n2;
                    Console.WriteLine(divide.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão impossível");
                }
            }
        }

        public static void CalculateFactorial()
        {
            /*Exercício 05: Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.*/

            Console.Write("Digite um número inteiro para o cálculo do fatorial: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            int counter;

            if (number < 0)
            {
                Console.WriteLine("Número inválido! Apenas números maiores ou iguais a zero!!");
            }
            else if (number == 0 || number == 1)
            {
                Console.WriteLine($"O fatorial de {number} é 1");
            }
            else
            {
                for (counter = number; counter >= 1; counter--)
                {
                    factorial *= counter;
                }
                Console.WriteLine($"Fatorial de {number} é {factorial}");
            }
        }

        public static void CalculatesDivisors()
        {
            /*Exercício 06: Ler um número inteiro N e calcular todos os seus divisores.*/

            Console.Write("Digite um número inteiro para calcular seu dividores: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void CalculateFrameCube()
        {
            /*Exercício 07: Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.*/
            
            Console.Write("Digite um número inteiro: ");
            int entryNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entryNumber; i++)
            {
                int numberLine = i;
                int lineSquared = (int) Math.Pow(i, 2);
                int lineCubed = (int) Math.Pow(i, 3);

                Console.WriteLine($"{numberLine} {lineSquared} {lineCubed}");
            }
        }
    }
}
