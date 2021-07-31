using System;

namespace Taller2_Ej3
{
    class Program
    {
        
            /*3. Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. 
            Determinar cuánto pagará, con IVA incluido (19%), un cliente si la compra cumple con esta condición.*/

            static double DescComputador(double precio)
            {
                double descuento = precio * 0.10;
                double total = precio - descuento;
                Console.WriteLine("Descontando el 10% de descuento sobre su compra, que es de: $ " + descuento);
                Console.ReadKey();
                Console.WriteLine("Su descuento quedaría en: $ " + total);
                return total;
            }

            public static void Iva(double valor)
            {
                double resultado = valor * 0.19;
                double total = valor + resultado;
                Console.ReadKey();
                Console.WriteLine("Con el iva del 19% queda su valor total en:  $ " + total);
            }

            public static void Main(String[] args)
            {
                double precio; 
                double descuento;
                Console.Write("Digite el precio de la computadora: ");
            try
            {
                precio = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un valor correcto: ");
                precio = double.Parse(Console.ReadLine());
            }         
             
                if (precio >= 1000000)
                {
                    descuento = DescComputador(precio);
                    Iva(descuento);
                }
                else
                {
                    Iva(precio);
                }
                Console.ReadKey();

            }

        }
    }

