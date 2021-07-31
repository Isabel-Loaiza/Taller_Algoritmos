using System;
/*
5.	Lea la distancia (en kilómetros) recorrida por un auto, el tiempo (en horas) 
en que la recorrió y calcule la velocidad a la cual se desplazaba el auto (V=D/T).
*/
namespace Ejercicio_5
{
    class Program
    {
        static double Velocidad (double distancia, double tiempo) => distancia / tiempo;
        static void Main(string[] args)
        {
            double distancia, tiempo;
            Console.WriteLine("Digite distancia en kilometros:");
            try
            {
                distancia = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite la distancia en kilometros:");
                distancia = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite tiempo en horas:");
            try
            {
                tiempo = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor Digite el tiempo en horas:");
                tiempo = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("La velocidad en la que se desplazo el auto fue: "+Velocidad(distancia, tiempo));
        }
    }
}
