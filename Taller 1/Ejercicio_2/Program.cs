using System;
/*
2.   Lea dos números y calcule el resultado de su suma, resta, multiplicación y división.
*/
namespace Ejercicio_2
{
    class Program
    {
        static int suma (int num1, int num2) => num1 + num2;

        static int resta (int num1, int num2) => num1 - num2;

        static int multipli (int num1, int num2) => num1 * num2;

        static double division (int num1, int num2) => num1 / num2;

        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Digite el primer número: ");
            try{
                num1 = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite en números el primer número: ");
                num1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite el segundo número: ");
            try
            {
                num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite en números el segundo número: ");
                num2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Suma: "+suma(num1, num2));
            Console.WriteLine("Resta: "+resta(num1, num2));
            Console.WriteLine("Multiplicación: "+multipli(num1, num2));
            Console.WriteLine("Division: "+division(num1, num2));
        }
    }
}
