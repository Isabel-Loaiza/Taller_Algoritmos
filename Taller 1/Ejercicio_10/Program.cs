using System;
/*

 10. Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente 
desea saber cuánto deberá pagar finalmente por su compra.

 */
namespace Ejercicio_10
{
    class Program
    {
        static double TotalPagar(double total){
            double totalPagar, descuento;
            descuento=total*0.15;
            totalPagar=total-descuento;
            return totalPagar;
            
        }
        static void Main(string[] args)
        {
            double total;
            Console.WriteLine("Digite total de la compra: ");
            try {
                total=double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente su total de la compra: ");
                total=double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Total a pagar es {TotalPagar(total)}");
            Console.ReadKey();
        }
    }
}
