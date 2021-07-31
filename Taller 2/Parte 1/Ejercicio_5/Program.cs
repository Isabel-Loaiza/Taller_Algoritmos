using System;

namespace Taller2_Ej5
{
    class Program
    {
        /*5. En un almacén se hace un 20% de descuento a los clientes cuya compra sea superior a $100.000. 
        ¿Cuánto deberá pagar cada cliente?*/
        
        static void Descuento(double precio)
        {
            double descuento = precio * 0.20;
            double total = precio - descuento;
            Console.WriteLine("El descuento es: $ " + descuento);
            Console.ReadLine();
            Console.WriteLine("El precio es: $ " + total);
        }

        public static void Main(String[] args)
        {
            double precio;

            Console.Write("Digite precio: ");
            try
            {
                precio = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un valor correcto: ");
                precio = double.Parse(Console.ReadLine());
            }
            

            if (precio > 100000)
            Descuento(precio);
            else
            Console.WriteLine("El precio es: $ " + precio);

            Console.ReadLine();
        }

    }
    }

