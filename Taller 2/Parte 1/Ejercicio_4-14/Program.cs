using System;

namespace Taller2_Ej4
{
    class Program
    {
        
            /*4. Realizar un algoritmo que lea dos números e imprima la suma de los 2, 
            en caso que el primero sea mayor al segundo*/
            static void Mayor(int n1, int n2)
            {
                if (n1 > n2)
                {
                    int suma = n1 + n2;
                    Console.WriteLine("La suma es: " + suma);
                }
                else if (n1 == n2)
                {
                    Console.WriteLine("Son números iguales");
                }
                else
                {
                Console.WriteLine("Los números son: " + n1 + ", " + n2);
                }
            }

        public static void leer()
        {
            int n1;
            int n2;
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
       
            Mayor(n1, n2);
        }

            public static void Main(String[] args)
            {
                leer();
            }
        }
    }

