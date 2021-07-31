using System;
/*

1.Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.

*/
namespace Ejercicio_1
{
    class Program
    {
        static void Primo(int numero){
            int contador_primos=0, j;
            bool primo;
            int i = 2;
            while (i<=numero)
            {
                primo=true;
                j=2;
                while (j<=i-1 && primo ==true){
                    if (i%j==0) primo =false;
                    j++;
                }
                if (primo==true)
                {
                    contador_primos++;
                    Console.WriteLine($"{i} es primo");
                }
                i++;
            }
            Console.WriteLine($"De 1 a {numero}, hay {contador_primos} números primos");
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite número: ");
            try {
                numero=int.Parse(Console.ReadLine());
            }catch(Exception) {
                Console.WriteLine("Por favor, Digite número: ");
                numero=int.Parse(Console.ReadLine());
            }
            Primo(numero);
        }
    }
}
