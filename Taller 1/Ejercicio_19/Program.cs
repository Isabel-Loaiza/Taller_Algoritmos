using System;

/*
19) Ingresar, para un estudiante, sus 5 notas de un curso, nombre, programa, ficha. Hacer un algoritmo que:
Muestre el nombre
Muestre el programa de formación

Se debe calcular y mostrar su promedio final.
*/

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int ficha;
            String nombre, programa;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese su programa de formaciòn: ");
            programa = Console.ReadLine();
            
            Console.WriteLine("Ingrese su ficha: ");
            try
            {
                ficha = int.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese su ficha con valores numèricos: ");
                ficha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
         
            double total = Notas();
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su programa de formaciòn y ficha son: " + programa + "-" + ficha);
            Console.WriteLine("Su promedio final es de: " + total);

            Console.ReadKey(true);
        }

        static double Notas()
        {
            double[] nota = new double[5];
            double total, suma = 0;
            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("Digite su nota " + (i + 1) + ": ");
                try
                {
                    nota[i] = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor, ingrese un nùmero: ");
                    nota[i] = double.Parse(Console.ReadLine());
                }
                suma += nota[i];
            }
            total = suma / 5;
            return total;
        }
    }
}
