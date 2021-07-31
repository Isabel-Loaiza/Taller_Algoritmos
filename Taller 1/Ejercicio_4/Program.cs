using System;
/*
4.	Dadas las 3 notas de un aprendiz, calcule la definitiva de la asignatura
   si la primera nota tiene un valor del 20%, la segunda del 30% y la última del 50%.
*/
namespace Ejercicio_4
{
    class Program
    {
        static double Notas (double nota1, double nota2, double nota3){
            double Notas = (nota1*0.2) + (nota2*0.3) + (nota3*0.5);
            return Notas;
        }
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;
            Console.WriteLine("Digite primera nota:");
            try
            {
                nota1 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite primera nota en números:");
                nota1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite segunda nota:");
            try
            {
                nota2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite segunda nota en números:");
                nota2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite tercera nota:");
            try
            {
               nota3 = double.Parse(Console.ReadLine()); 
            }
            catch (Exception)
            {
                Console.WriteLine("Digite tercera nota en números:");
                nota3 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota definitiva: "+Notas(nota1, nota2, nota3));
        }
    }
}
