namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas
            contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz.
            Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver.*/

            Console.Write("Entre com o números de linhas da matriz: ");
            int numberLines = int.Parse(Console.ReadLine());
            Console.Write("Entre com o números de colunas da matriz: ");
            int numberColumns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[numberLines, numberColumns];

            for (int i = 0; i < numberLines; i++)
            {
                Console.Write($"Entre com os números da linha {i + 1}: ");
                string[] lineValue = Console.ReadLine().Split(' ');

                for (int j = 0; j < numberColumns; j++)
                {
                    matrix[i, j] = int.Parse(lineValue[j]);
                }
            }
        }
    }
}