using System;
/*7. Leer un número e imprimir un mensaje en caso que sea negativo.*/
namespace Taller2_Ej7
{
    class Program
    {
        public static void Negativo(int numero)
        {
            if (numero < 0) Console.WriteLine("El número " + numero + " es negativo.");
        }

        public static void Main(String[] args)
        {
            int numero;
            Console.Write("Digite un número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un número: ");
                numero = int.Parse(Console.ReadLine());
            }

            Negativo(numero);
        }
    }
}

