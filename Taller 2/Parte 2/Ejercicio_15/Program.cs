using System;
/*

15.En un almacén se hace un 17% de descuento a los clientes cuya compra sea superior a $200.000, 
para las compras inferiores, el descuento será del 5%. ¿Cuánto deberá pagar cada cliente?

 */
namespace Ejercicio_15
{
    class Program
    {
        static void totalPagar(double precio){
            double total, descuento;
            descuento = precio>200000?precio*0.17:precio*0.05;
            total = precio - descuento;
            Console.WriteLine($"\nEl descuento es de {descuento}\nEl total a pagar es: {total}");
        }
        static void Main(string[] args)
        {
            double precio;
            Console.WriteLine("Digite precio de compra: ");
            try {
                precio = double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite precio de compra: ");
                precio = double.Parse(Console.ReadLine());
            }
            totalPagar(precio);
        }
    }
}
