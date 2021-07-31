using System;

/*
10.Leer la edad de una persona e imprimir un mensaje en caso que sea mayor de edad.
*/

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Digite edad: ");
            try
            {
                edad = int.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un nùmero: ");
                edad = int.Parse(Console.ReadLine());
            }

                if (edad >= 18)
                Console.WriteLine("¡Es mayor de edad!");
                else
                Console.WriteLine("No eres mayor de edad.");
        }
    }
}
