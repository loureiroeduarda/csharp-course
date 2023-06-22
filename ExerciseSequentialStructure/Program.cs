using System.Globalization;

namespace ExerciseSequentialStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition();
            // CalculateCircleArea();
            // CalculateProductDifference();
            // SalaryCalculation();
            // CalculateAmountPaid();
            // CalculateAreaGeometricShapes();
        }

        public static void Addition()
        {
            /*Exercício 01: Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            mensagem explicativa, conforme exemplos.*/

            Console.WriteLine("Soma de valores!!");
            Console.WriteLine("Entre com o primero número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 + n2;
            Console.WriteLine("SOMA = " + result);
        }

        public static void CalculateCircleArea()
        {
            /*Exercício 02: Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159*/

            double radius, circleArea;
            const double pi = 3.14159;

            Console.WriteLine("Entre com o valor do raio de um círculo:");
            radius = double.Parse(Console.ReadLine());

            circleArea = pi * Math.Pow(radius, 2);
            Console.WriteLine("A = " + circleArea.ToString("F4"));
        }

        public static void CalculateProductDifference()
        {
            /*Exercício 03: Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            int n1, n2, n3, n4, productResult;

            Console.WriteLine("Para realizar a seguinte operação: DIFERENCA = (A * B - C * D)");
            Console.WriteLine("Entre com o primero número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro número:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o quarto número:");
            n4 = int.Parse(Console.ReadLine());

            productResult = (n1 * n2) - (n3 * n4);
            Console.WriteLine("DIFERENÇA = " + productResult);
        }

        public static void SalaryCalculation()
        {
            /*Exercício 04: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais*/

            int employeeNumber, workedHours;
            double valueHour, salary;

            Console.WriteLine("Digite o número do funcionário:");
            employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas:");
            workedHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor recebido por hora:");
            valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = workedHours * valueHour;

            Console.WriteLine("Número funcionário = " + employeeNumber);
            Console.WriteLine("Salário = " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void CalculateAmountPaid()
        {
            /*Exercício 05: Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago*/

            int code1, code2, pieceQuantity1, pieceQuantity2;
            double unitValuePiece1, unitValuePiece2, amount;

            Console.WriteLine("Digite o código da peça 1:");
            code1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças 1:");
            pieceQuantity1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da peça 1:");
            unitValuePiece1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 2:");
            code2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças 2:");
            pieceQuantity2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da peça 2:");
            unitValuePiece2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            amount = (pieceQuantity1 * unitValuePiece1) + (pieceQuantity2 * unitValuePiece2);

            Console.WriteLine("VALOR A PAGAR: " + amount.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void CalculateAreaGeometricShapes()
        {
            /*Exercício 06: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
            a) a área do triângulo retângulo que tem A por base e C por altura. 
            b) a área do círculo de raio C. (pi = 3.14159) 
            c) a área do trapézio que tem A e B por bases e C por altura. 
            d) a área do quadrado que tem lado B. 
            e) a área do retângulo que tem lados A e B.*/

            float a, b, c, triangleArea, circleArea, trapezeArea, squareArea, rectangleArea;
            const float pi = 3.14159f;

            Console.WriteLine("Entre com o número A, B e C (mesma linha):");
            string[] vector = Console.ReadLine().Split(' ');
            a = float.Parse(vector[0], CultureInfo.InvariantCulture);
            b = float.Parse(vector[1], CultureInfo.InvariantCulture);
            c = float.Parse(vector[2], CultureInfo.InvariantCulture);


            triangleArea = a * c / 2;
            circleArea = pi * (float)Math.Pow(c, 2);
            trapezeArea = (a + b) / 2 * c;
            squareArea = (float)Math.Pow(b, 2);
            rectangleArea = a * b;

            Console.WriteLine("ÁREA TRIANGULO: " + triangleArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("ÁREA CÍRUCLO: " + circleArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("ÁREA TRAPEZIO: " + trapezeArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("ÁREA QUADRADO: " + squareArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("ÁREA RETANGULO: " + rectangleArea.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}