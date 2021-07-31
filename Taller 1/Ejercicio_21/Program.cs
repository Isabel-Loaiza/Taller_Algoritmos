using System;

namespace ejercicio21
{
    class Program
    {
       /*Realice un algoritmo que permita realizar el cálculo del siguiente enunciado, 
        se solicita el año de nacimiento del aprendiz, el nombre, la dirección, 
       se requiere conocer la edad de la persona y la información completa ingresada. 
 */
         public static void Main(String[] args)
        {
           
           double edad, nacimientoP;
            String nombre, direccion;

            Console.Write("ingrese  el  año de nacimiento del aprendiz: ");
            try
            {
                nacimientoP = double.Parse(Console.ReadLine());
            }
            catch (Exception) {
                Console.Write ("Por favor digite un año correcto: ");
                nacimientoP = double.Parse(Console.ReadLine());
            }
            

            Console.Write("ingrese  el nombre del aprendiz: ");
            try
            {
                nombre = Console.ReadLine();
            }
            catch (Exception) {
                Console.Write("Por favor escriba un nombre correcto: ");
                nombre = Console.ReadLine();
            }

            

            Console.Write("ingrese  la dirección  del aprendiz; ");
            try
            {
                direccion = Console.ReadLine();
            }
            catch (Exception) {
                Console.Write("Por favor escriba un Dirección correcta: ");
                direccion = Console.ReadLine();
            }

            

            edad = 2021 - nacimientoP;
            Console.WriteLine("la edad del aprendiz es: " + edad);
        }
        }
    }

