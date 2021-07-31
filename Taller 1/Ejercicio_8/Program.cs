using System;
/*
8. Suponga que un individuo desea invertir su capital en un banco y desea saber 
cuánto dinero ganará después de un mes si el banco paga a razón de 2% mensual.
 */

namespace Ejercicio_8
{
    class Program
    {
        static double Pago (double valorInvertido){
            double valor=valorInvertido*0.02;
            double pago=valor+valorInvertido;
            return pago;
        }
        static void Main(string[] args)
        {
            double valorInvertido;
            Console.WriteLine("Digite el valor invertido");
            try {
                valorInvertido= double.Parse(Console.ReadLine());
            }catch(Exception) {
                Console.WriteLine("Por favor, digite nuevamente su valor invertido");
                valorInvertido= double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El pago mensual es: {Pago(valorInvertido)}");
            Console.ReadKey();
        }
    }
}
