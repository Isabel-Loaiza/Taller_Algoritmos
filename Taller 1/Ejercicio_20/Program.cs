using System;

/*
20) Ingresar el precio de compra unitario de un producto y la cantidad de compra de dicho producto y un descuento. 
Calcular y mostrar el subtotal, el monto del IVA que es el 19% del subtotal, y el precio neto 
(precio parcial con el Monto del IVA).
*/

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double precioC;
            int cant;

            Console.WriteLine("Ingrese el precio de compra unitario del producto: ");
            try
            {
                precioC = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese valores numèricos: ");
                precioC = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese la cantidad del producto: ");
            try
            {
                cant = int.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese valores numèricos: ");
                cant = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("¡¡El descuento que se le hace al producto es del 10%!!");
            Console.WriteLine(" ");

            Operaciones(precioC, cant);

            Console.ReadKey();
        }
        static void Operaciones(double precioC, int cant)
        {
            double valor, cantiDes, descuentoValor, descuento = 0.1, montoIVA, Iva = 0.19, precioNeto;

            valor = cant * precioC;
            cantiDes = valor * descuento;
            descuentoValor = valor - cantiDes;
            montoIVA = descuentoValor * Iva;
            precioNeto = descuentoValor + montoIVA;

            Console.WriteLine("El subtotal es: " + descuentoValor);
            Console.WriteLine("El monto del IVA es: " + montoIVA);
            Console.WriteLine("El precio neto es: " + precioNeto);
        }

    }
}
