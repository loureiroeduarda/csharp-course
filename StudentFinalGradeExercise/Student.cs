using System.Globalization;

namespace StudentFinalGradeExercise
{
    public class Student
    {
        public string Name;
        public double Grade1, Grade2, Grade3;

        public double CalculateFinalGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public static void PrintStudentStatus(double finalGrade)
        {
            if (finalGrade < 60.00)
            {
                double missingPoints = 60.00 - finalGrade;
                Console.WriteLine("NOTA FINAL " + finalGrade.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + missingPoints.ToString("F2"), CultureInfo.InvariantCulture + " PONTOS");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + finalGrade.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("APROVADO");
            }
        }
    }
}