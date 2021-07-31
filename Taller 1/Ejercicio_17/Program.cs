using System;

/*
17. Desarrollar un algoritmo que permita generar la colilla de pago de los empleados de una empresa. La colilla debe mostrar:
• El Salario del Empleado 
• El Valor de Ahorro mensual programado.
• La suma a deducir por aporte a la Salud (EPS) 12,5%
• La suma a deducir por aporte al Fondo de Pensiones 16%
• Total a Recibir 
• Toda la información que debe proveer el usuario del programa es el Salario del Empleado 
y el Valor de Ahorro mensual programado. El programa debe calcular y devolver el resto de los datos.
*/

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double ahorroM, salario;
            Console.Write("Ingrese el salario del empleado: ");
            try
            {
                salario = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese valores en nùmeros: ");
                salario = double.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese el valor de ahorro mensual programado: ");
            try
            {
                ahorroM = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese valores en nùmeros: ");
                ahorroM = double.Parse(Console.ReadLine());
            }
            Datos(salario, ahorroM);
            Proceso(salario, ahorroM);

            Console.ReadKey(true);
        }
        static void Datos(double salario, double ahorroM)
        {
            Console.WriteLine("Su salario y valor del ahorro mensual programado es: " + salario + " y " + ahorroM);
        }
        static void Proceso(double salario, double ahorroM)
        {
            double EPS = (salario * 12.5)/100;
            double pension = salario * 0.16;
            double total = salario - (EPS + pension + ahorroM);

            Console.WriteLine("La suma a deducir por aporte a la Salud es: " + EPS);
            Console.WriteLine("La suma a deducir por aporte al Fondo de Pensiones es: " + pension);
            Console.WriteLine("");
            Console.WriteLine("El salario total del empleado es: " + total);
        }
    }
}