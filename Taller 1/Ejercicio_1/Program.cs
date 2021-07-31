using System;
/*
1.	Lea tres números y calcule el resultado de su suma.
*/
namespace Ejercicio_1
{
    class Program
    {
        static void Sumar (int num1, int num2, int num3) {
            int sumar = num1 + num2 + num3;
            Console.WriteLine("La suma es:"+ sumar);
        }

        static void Main(string[] args)
        {   
            int num1, num2, num3;
            Console.WriteLine("Digite primer número:");
            try{
                num1 = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite primer Número: ");
                num1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite segundo número:");
            try{
                num2 = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite segundo número:");
                num2 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite tercer número:");
            try{
                num3 = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite tercer número:");
                num3 = int.Parse(Console.ReadLine());
            }
            Sumar(num1, num2, num3);
        }
    }
}
