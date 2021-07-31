using System;

namespace Taller1_Ej13
{
    class Program
    {
        /*13. Dada las horas trabajadas de una persona y el valor por hora. Calcular su salario e imprimirlo. */

   
         static void salario(int Horas, double ValorHora)
        {
            double Salario; 
            Salario = Horas * ValorHora;
            Console.WriteLine("El salario es: $ " + Salario);
     
        }

        public static void Main(String[] args)
        {
            int Horas;
            double ValorHora;

            Console.WriteLine("Digite las horas trabajadas: ");
            try
            {
                Horas = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digita un número: ");
                Horas = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("Digite el valor de cada hora: ");
            try 
            {
                ValorHora = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digita un número: ");
                ValorHora = double.Parse(Console.ReadLine());
            }

            salario(Horas, ValorHora);
        }
      }
    }

