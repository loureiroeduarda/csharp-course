namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas
            contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz.
            Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver.*/

            Console.Write("Enter the number of rows in the matrix: ");
            int numberLines = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int numberColumns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[numberLines, numberColumns];

            for (int i = 0; i < numberLines; i++)
            {
                Console.Write($"Enter the numbers that formed the matrix {i + 1}: ");
                string[] lineValue = Console.ReadLine().Split(' ');

                for (int j = 0; j < numberColumns; j++)
                {
                    matrix[i, j] = int.Parse(lineValue[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Enter a number that belongs to the matrix: ");
            int numberMatrix = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    if (matrix[i, j] == numberMatrix)
                    {
                        Console.WriteLine();
                        Console.Write($"Position of number {numberMatrix} is [{i},{j}]" + "\n"); 

                        if (j > 0)
                        {
                            int numberLeft = matrix[i, j - 1];
                            Console.Write($"Number to the left is {numberLeft}" + "\n");
                        }
                        if (j < numberColumns - 1)
                        {
                            int numberRight = matrix[i, j + 1];
                            Console.Write($"Number to the right is {numberRight}" + "\n");
                        }
                        if (i < numberLines - 1)
                        {
                            int numberDown = matrix[i + 1, j];
                            Console.Write($"Number to the down is {numberDown}" + "\n");
                        }
                        if (i > 0)
                        {
                            int numberUp = matrix[i - 1, j];
                            Console.Write($"Number to the up is {numberUp}" + "\n");
                        }
                    }
                }
            }
        }
    }
}