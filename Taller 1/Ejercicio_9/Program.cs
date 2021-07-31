using System;
/*

9.Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea 
saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza 
en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.

 */
namespace Ejercicio_9
{
    class Program
    {
        static double Total (double sueldo, double venta1, double venta2, double venta3){
            double total, ventas;
            ventas = venta1*0.10 + venta2*0.10 + venta3*0.10;
            total=ventas+sueldo;
            return total;
        }
        static void Main(string[] args)
        {
            double sueldo, venta1, venta2, venta3;
            Console.WriteLine("Digite su sueldo: ");
            try {
                sueldo = double.Parse(Console.ReadLine());
            }catch(Exception) {
                Console.WriteLine("Digite nuevamente su sueldo");
                sueldo = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite el valor de la 1 venta:");
            try {
                venta1=double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente el valor de la 1 venta:");
                venta1=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite el valor de la 2 venta:");
            try {
                venta2=double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente el valor de la 2 venta:");
                venta2=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite el valor de la 3 venta:");
            try {
                venta3=double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente el valor de la 3 venta:");
                venta3=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sueldo total: "+Total(sueldo, venta1, venta2, venta3));
            Console.ReadKey();
        }
    }
}
