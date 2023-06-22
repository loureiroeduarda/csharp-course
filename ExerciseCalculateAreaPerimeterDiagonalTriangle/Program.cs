namespace ExerciseCalculateAreaPerimeterDiagonalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de 
            sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.*/

            Rectangle rectangle = new Rectangle();  

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            rectangle.Width = double.Parse(Console.ReadLine());
            rectangle.Height = double.Parse(Console.ReadLine());

            Console.WriteLine(rectangle);
        }
    }
}