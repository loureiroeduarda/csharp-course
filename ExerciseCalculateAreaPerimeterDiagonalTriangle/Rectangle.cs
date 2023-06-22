using System.Globalization;

namespace ExerciseCalculateAreaPerimeterDiagonalTriangle
{
    public class Rectangle
    {
        public double Width;
        public double Height;

        public double RectangleArea()
        {
            return Width * Height;
        }

        public double RectanglePerimeter()
        {
            return 2 * (Width + Height);
        }

        public double DiagonalRectangle()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

        override public string ToString()
        {
            return "AREA = " + RectangleArea().ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "PERÍMETRO = " + RectanglePerimeter().ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "DIAGONAL = " + DiagonalRectangle().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
