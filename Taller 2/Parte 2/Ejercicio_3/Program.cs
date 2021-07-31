using System;
/*
3.Elabore un algoritmo que lea un número y si este es mayor o 
igual a 10 devuelva el triple de este de lo contrario la cuarta parte de este.
 */
namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }catch(Exception)
            {
                Console.WriteLine("Por favor, ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
            }
        if (numero >= 10)
        Console.WriteLine("El triple de el número " + numero + " es: " + numero * 3);
        
        else
        Console.WriteLine("La cuarta parte de el número " + numero + " es: " + numero / 4);
        }
    }
}
