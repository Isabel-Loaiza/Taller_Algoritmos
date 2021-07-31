using System;

/*
15. Realizar un algoritmo que lea un número y si éste es superior o igual a 10, permita imprimir su cubo.
*/

namespace Ejercicio_13
{
    class Program
    {
        static void Operacion(int numero)
        {
            if (numero >= 10)
            {
                int resultado = numero * numero * numero;
                Console.WriteLine("El cubo de el número " + numero + " es: " + resultado);
            }
            else
            {
                Console.WriteLine("Número: " + numero);
            }
        }

        static void Main(String[] args)
        {
                int numero;
                Console.WriteLine("Digite número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, digite un nùmero: ");
                numero = int.Parse(Console.ReadLine());
            }

                Operacion(numero);
        }

    }
}
