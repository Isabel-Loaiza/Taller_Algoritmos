using System;

/*
9.Leer un número e imprimir un mensaje en caso que sea múltiplo de 5.
*/

namespace Ejercicio_9
{
    class Program
    {
        public static void Main(String[] args)
        {
            int numero;
            Console.WriteLine("Digite número");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, digite un nùmero: ");
                numero = int.Parse(Console.ReadLine());
            }

            int resul = numero % 5;

            if (resul == 0)
                Console.WriteLine(numero + " es múltiplo de 5");
            else
                Console.WriteLine("El nùmero " + numero + " no es múltiplo de 5.");
        }
    }
}
