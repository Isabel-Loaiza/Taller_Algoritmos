using System;
/*
3.	Dadas las 3 notas de un aprendiz, calcule la definitiva de la asignatura.
*/
namespace Ejercicio_3
{
    class Program
    {
        static double Notas (double nota1, double nota2, double nota3) => (nota1+nota2+nota3)/3;
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;
            Console.WriteLine("Digite primera nota:");
            try
            {
                nota1 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite primera nota en números:");
                nota1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite segunda nota:");
            try
            {
                nota2 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite segunda nota en números:");
                nota2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite tercera nota:");
            try
            {
                nota3 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite tercera nota en números:");
                nota3 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nota definitiva: "+Notas(nota1, nota2, nota3));
        }
    }
}
