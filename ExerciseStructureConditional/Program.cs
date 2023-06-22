using System.Globalization;

namespace ExerciseStructureConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckNegativeNumber();
            // CheckEvenOddNumber();
            // CheckMultipleNumbers();
            // CalculateGameDuration();
            // CalculateBillPaid();
            // ShowInterval();
            // CalculatesCoordinates();
            // CalculateIncomeTax();
        }

        public static void CheckNegativeNumber()
        {
            /*Exercício 01: Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/

            Console.WriteLine("Entre com um número inteiro:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }

        public static void CheckEvenOddNumber()
        {
            /*Exercício 02: Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/

            Console.WriteLine("Entre com um número inteiro:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        public static void CheckMultipleNumbers()
        {
            /*Exercício 03: Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            ordem crescente ou decrescente.*/

            Console.WriteLine("Entre com os números inteiros A e B:");
            string[] vector = Console.ReadLine().Split(' ');
            int a = int.Parse(vector[0]);
            int b = int.Parse(vector[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("SÃO MÚLTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            }
        }

        public static void CalculateGameDuration()
        {
            /*Exercício 04: Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

            Console.WriteLine("Entre com a hora inicial e com a hora final do jogo:");
            string[] vector = Console.ReadLine().Split(' ');
            int startTime = int.Parse(vector[0]);
            int endTime = int.Parse(vector[1]);

            int duration;
            if (startTime < endTime)
            {
                duration = endTime - startTime;
            }
            else
            {
                duration = 24 - startTime + endTime;
            }

            Console.WriteLine("O JOGO DUROU " + duration + " HORA(S)");
        }

        public static void CalculateBillPaid()
        {
            /*Exercício 05: Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            seguir, calcule e mostre o valor da conta a pagar.*/

            Console.WriteLine("Digite o código do item consumido:");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade consumida:");
            int quantity = int.Parse(Console.ReadLine());

            double result = 0;
            if (code == 1)
            {
                result = quantity * 4.00;
            }
            else if (code == 2)
            {
                result = quantity * 4.50;
            }
            else if (code == 3)
            {
                result = quantity * 5.00;
            }
            else if (code == 4)
            {
                result = quantity * 2.00;
            }
            else if (code == 5)
            {
                result = quantity * 1.50;
            }
            else
            {
                Console.WriteLine("Este item não existe!!");
            }
            Console.WriteLine("O valor da conta a pagar é R$ " + result.ToString("F2"));
        }

        public static void ShowInterval()
        {
            /*Exercício 06: Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/

            Console.WriteLine("Digite um número:");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number >= 0 && number <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (number >= 25 && number <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (number >= 50 && number <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (number >= 75 && number <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }

        public static void CalculatesCoordinates()
        {
            /*Exercício 07: Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o 
            ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.*/

            Console.WriteLine("Entre com valor de X e com valor de Y:");
            string[] vector = Console.ReadLine().Split(' ');
            double x = double.Parse(vector[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vector[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo x");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        public static void CalculateIncomeTax()
        {
            /*Exercício 08: Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos
            corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto
            de Renda, segundo a tabela abaixo.

            Renda de 0.00 a R$ 2000.00 isento.
            Renda de R$ 2000.01 a R$ 3000.00 desconto de 8% de imposto de renda.
            Renda de R$ 3000.01 a R$ 4500.00 desconto de 18% de imposto de renda.
            Renda acima de R$ 4500.00 desconto de 28% de imposto de renda.

            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta
            de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser
            impresso com duas casas decimais.*/

            Console.WriteLine("Digite o salário:");
            double salary = double.Parse(Console.ReadLine());

            double taxValue = 0;
            if (salary <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salary > 2000.00 && salary <= 3000.00)
            {
                taxValue = (salary - 2000.0) * 0.08;
            }
            else if (salary > 3000.00 && salary <= 4500.00)
            {
                taxValue = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                taxValue = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            Console.WriteLine("R$ " + taxValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}