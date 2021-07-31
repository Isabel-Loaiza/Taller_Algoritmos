using System;
/*

7.Leer un número e imprimir un mensaje si es par o impar.

 */
namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            String mensaje;
            Console.WriteLine("Digite un número: ");
            try {
                numero = int.Parse(Console.ReadLine());
            }catch(Exception) {
                Console.WriteLine("Por favor, digite un número: ");
                numero = int.Parse(Console.ReadLine());
            }
            mensaje= numero%2==0?"El número es par": "El número es impar";
            Console.WriteLine(mensaje);
        }
    }
}
