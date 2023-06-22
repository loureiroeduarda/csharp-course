using System.Globalization;

namespace ExerciseStructureWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // PasswordReader();
            // ReaderCoordinates();
            FuelType();
        }

        public static void PasswordReader()
        {
            /*Exercício 01: Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/

            Console.Write("Digite a senha (apenas números): ");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("Senha inválida! Digite novamente!!");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!!");
        }

        public static void ReaderCoordinates()
        {
            /*Exercício 02: Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

            Console.Write("Digite a coordenada X e a coordenada Y: ");
            string[] vector = Console.ReadLine().Split(' ');
            double x = double.Parse(vector[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vector[1], CultureInfo.InvariantCulture);
            
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto quadrante");
                }
                Console.Write("Digite a coordenada X e a coordenada Y: ");
                vector = Console.ReadLine().Split(' ');
                x = double.Parse(vector[0], CultureInfo.InvariantCulture);
                y = double.Parse(vector[1], CultureInfo.InvariantCulture);
            }
        }

        public static void FuelType()
        {
            /*Exercício 03: Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
            Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido).
            O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO"
            e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.*/

            int amountAlcohol = 0;
            int amountGasoline = 0;
            int amountDiesel = 0;

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Digite o tipo de combustível abastecido:");
                Console.WriteLine("1. Álcool");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Fim");
                int fuelType = int.Parse(Console.ReadLine());

                if (fuelType == 1)
                {
                    amountAlcohol++;
                }
                else if (fuelType == 2)
                {
                    amountGasoline++;
                }
                else if (fuelType == 3)
                {
                    amountDiesel++;
                }
                else if (fuelType == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO!");
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente!!");
                }
            }
            Console.WriteLine("Álcool: " + amountAlcohol + "\n" + "Gasolina: " + amountGasoline + "\n" + "Diesel: " + amountDiesel);
        }
    }
}

