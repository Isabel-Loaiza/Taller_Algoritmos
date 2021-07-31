using System;

/*
12.Hacer un algoritmo que lea la estatura de una persona y si es mayor de 1.70, imprima que es alta
*/

namespace Ejercicio_12
{
    class Program
    {
        static void Main(String[] args)
        {
            double estatura;
            Console.WriteLine("Digite estatura: ");
            try
            {
                estatura = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, digite valores numèricos");
                estatura = double.Parse(Console.ReadLine());
            }
                if (estatura >= 1.70)
                    Console.WriteLine("Es alto(a)");
        }
    }
}
