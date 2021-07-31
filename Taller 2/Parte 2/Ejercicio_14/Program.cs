using System;
/*

14.Elaborar un algoritmo que lea un número, si es par, que imprima el cubo y si es impar, que imprima el triple.
 
*/
namespace Ejercicio_14
{
    class Program
    {
        static void Numero (int numero){
            if (numero%2==0)
            {
                int resultado=numero*numero*numero;
                Console.WriteLine($"El número es par\nEl cubo del número {numero} es {resultado}");
            } else {
                Console.WriteLine($"El número es impar\n El triple del número {numero} es {numero*3}");
            }
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un número: ");
            try {
                numero = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite un número: ");
                numero = int.Parse(Console.ReadLine());
            }
            Numero(numero);
        }
    }
}
