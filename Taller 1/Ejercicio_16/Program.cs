using System;

namespace Taller1_Ej16
{
    class Program
    {

        /*16. Suponga que un conductor le pide a usted que le haga un algoritmo para calcular 
         cuánto le corresponde en un día trabajado, teniendo en cuenta que tiene derecho a el 
         19% del total recaudado.*/

        static void Valor(float Recaudo)
        {
            float Valor;
            float Sueldo;

            Valor = (float)(Recaudo * 0.19);
            Sueldo = Valor;
            Console.WriteLine("Tiene derecho al 19% de: $" + Recaudo + " esto equivale al: $" + Sueldo);
        }

        public static void Main(String[] args)
        {
            float Recaudo;

            Console.Write("Digite el valor total recaudado: ");
            try
            {
                Recaudo = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor digite un valor correcto: ");
                Recaudo = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("");

            Valor(Recaudo);

        }
    }
    }

