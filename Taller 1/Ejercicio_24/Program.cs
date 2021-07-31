using System;

namespace Ejercicio_24
{
    class Program
    {
        /*
        24) Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es del 5% anual, 
            se debe solicitar el monto del préstamo y se desea calcular la siguiente información.

            • Cuanto dinero se ha pagado de intereses en un año. 
            • Cuanto dinero se ha pagado de intereses en el tercer trimestre del año.
            • Cuanto dinero se ha pagado de intereses en el primer mes.
            • Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses.
         */
        static void Interes(double prestamo)
        {
            double interes1, intereses2, interesCompleto, interesesT, interesMensual;
            interes1 = 0.05 * prestamo;
            interesMensual = (interes1 * 12) / 100;
            intereses2 = 9 * interesMensual;
            interesCompleto = interes1 * 5;
            interesesT = prestamo + interesCompleto;

            Console.WriteLine("\n---------------\nEsto se pagaría de intereses durante un año: " + interes1);
            Console.WriteLine("Esto se pagaría de intereses en el tercer trimestre del año: " + intereses2);
            Console.WriteLine("Esto se pagaría de intereses durante un mes: " + interesMensual);
            Console.WriteLine("Esto se pagaría en total contando intereses: " + interesesT);
        }
        static void Main(string[] args)
        {
            double prestamo;

            Console.Write("¿De cuànto desea realizar el prestamo?: ");
            try{
                prestamo = double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.Write("Por favor, ingrese valores numèricos: ");
                prestamo = double.Parse(Console.ReadLine());
            }
            Interes(prestamo);
        }
    }
}
