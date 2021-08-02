using System;

/*
1. Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original 
y su precio con descuento. El descuento lo hace en base a la clave, 
si la clave es 01 el descuento es del 10% y si la clave es 02 el descuento es del 20% (solo existen dos claves).
*/

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int resp;
            double precio, descuento, total;

            Console.WriteLine("Digite nombre del artículo: ");
            nombre = Console.ReadLine();

            try
            {
                Console.WriteLine("Digite precio: ");
                precio = double.Parse(Console.ReadLine());

            }
            catch (FormatException e)
            {
                Console.WriteLine("Escribió una letra, digite el precio nuevamente");
                Console.WriteLine("Digite precio: ");
                precio = double.Parse(Console.ReadLine());
            }
            String[] clave = { "01", "02" };
            Console.WriteLine("¿Qué clave desea elegir? 01 - 02");
            resp = int.Parse(Console.ReadLine());
            string mensaje = "";
            if (resp == 01)
            {
                descuento = precio * 0.1;
                total = precio - descuento;
                mensaje = "";
            }
            else if (resp == 02)
            {
                descuento = precio * 0.2;
                total = precio - descuento;
                mensaje = "";
            }
            else
            {
                total = 0;
                mensaje = "\nNo digitó una clave por lo tanto no tiene descuento";
            }

            Console.WriteLine("");
            Console.WriteLine("Nombre del artículo: " + nombre + "\nClave: " + resp + "\nPrecio: " + precio + "\nPrecio con descuento: " + total + " " + mensaje);
        }
    }
}
