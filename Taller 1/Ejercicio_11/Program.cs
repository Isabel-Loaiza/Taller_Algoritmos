using System;

/*
11. Un alumno desea saber cuál será su calificación final en la materia de Algoritmos.  
    Dicha calificación se compone de los siguientes porcentajes:

	55% del promedio de sus tres calificaciones parciales.
 	30% de la calificación del examen final. 
	15% de la calificación de un trabajo final
 */

namespace Ejercicio_11
{
    class Program
    {
        static double notaDefi(double nota1, double nota2, double nota3, double nota4, double nota5)
        {
            double notaDefi, notasP, notasE, notasT;
            notasP = (nota1 + nota2 + nota3) / 3 * 0.55;
            notasE = nota4 * 0.3;
            notasT = nota5 * 0.15;
            notaDefi = notasP + notasE + notasT;
            return notaDefi;
        }

        static void Main(String[] args)
        {
            double nota1, nota2, nota3, nota4, nota5;

            Console.WriteLine("Digite la 1 nota parcial: ");
            try
            {
                nota1 = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un nùmero: ");
                nota1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite la 2 nota parcial: ");
            try
            {
                nota2 = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un nùmero: ");
                nota2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite la 3 nota parcial: ");
            try
            {
                nota3 = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un nùmero: ");
                nota3 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite la nota del examen final: ");
            try
            {
                nota4 = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un nùmero: ");
                nota4 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite la nota del trabajo final: ");
            try
            {
                nota5 = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un nùmero: ");
                nota5 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nota final: " + notaDefi(nota1, nota2, nota3, nota4, nota5));

            Console.ReadKey(true);
        }
    }
}
