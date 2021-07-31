using System;

namespace Taller2_Ej2
{
    class Program
    {
        
            /*2. Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este.*/
            static void Triple(int numero)
            {
            
            if (numero >= 10)
                {
                int triple;
                triple = numero * 3;
                Console.WriteLine("El triple de " + numero + " es: " + triple);              
                }
                else
                {
                Console.WriteLine("El número es: " + numero);
                }
            }

            public static void Main(String[] args)
            {
                int numero;
                Console.Write("Digite número: ");
            try
            { 
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un número: ");
                numero = int.Parse(Console.ReadLine());
            }
               
                Triple(numero);
            }
        }
    }

