using System;

namespace Taller2_Ej3
{
    class Program
    {
        /*4. Hacer un algoritmo que lea dos números y los imprima en orden ascendente.*/
        public static void Main(String[] args)
        {

            int n1, n2;
            Console.Write("Digite el primer número: ");
            try
            {
                n1 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un número: ");
                n1 = int.Parse(Console.ReadLine());
            }
            

            Console.Write("Digite el segundo número: ");
            try
            {
                n2 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un número: ");
                n2 = int.Parse(Console.ReadLine());
            }
           

            if (n1 > n2)
            {
                Console.WriteLine(n2 + ", " + n1);
            }
            else if (n1 < n2)
            {
                Console.WriteLine(n1 + ", " + n2);
            }
            else
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}
