﻿using System.Globalization;

namespace StudentFinalGradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
            aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
            problema.*/
            
            Student student = new Student();

            Console.Write("Digite o nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.Grade1 = double.Parse(Console.ReadLine());
            student.Grade2 = double.Parse(Console.ReadLine());
            student.Grade3 = double.Parse(Console.ReadLine());
                      
            Student.PrintStudentStatus(student.CalculateFinalGrade());
        }
    }
}