using System;

/*
11. Leer 4 notas, calcular el promedio e imprimir un mensaje indicando que reprobó 
en caso que la nota sea menor a 3.5
*/

namespace Ejercicio_11
{
    class Program
    {
            static void Menor(double promedio)
            {
                if (promedio < 3.5)
                Console.WriteLine("Usted reprobó.");
                
                else
                Console.WriteLine("Su nota es: " + promedio);
            }

            static void Leer()
            {
                double[] nota = new double[4];
                double promedio, suma = 0;
                for (int i = 0; i < nota.Length; i++)
                {
                Console.WriteLine("Digite nota " + (i + 1) + ": ");
                try
                {
                    nota[i] = double.Parse(Console.ReadLine());
                }catch (Exception)
                {
                    Console.WriteLine("Por favor, ingrese un nùmero: ");
                    nota[i] = double.Parse(Console.ReadLine());
                }
                    suma += nota[i];
                }
                promedio = suma / 4;
                Menor(promedio);
            }

            static void Main(String[] args)
            {
                Leer();
            }
    }
}

