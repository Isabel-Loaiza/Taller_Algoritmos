using System;

namespace Taller2_Ej1
{
    class Program
    {
       
            /*1. Leer un número e imprimir un mensaje en caso que sea par.*/
             static void Par(int numero)
            {
                if (numero % 2 == 0) 
                Console.WriteLine("El número " + numero + " es par");
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
                      
                Par(numero);
            }
        }
    }

