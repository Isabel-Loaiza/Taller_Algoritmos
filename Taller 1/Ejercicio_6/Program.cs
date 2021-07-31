using System;
/*

6.Lea la cantidad de dinero correspondiente a una compra y calcule el valor del IVA (19%), y el valor
total de la factura, si al valor de la compra se le autoriza un descuento del 10% (antes de aplicarle el IVA).

 */
namespace Ejercicio_6
{
    class Program
    {
        static double Compras(double valor, int resp)
        {
            double total, total1, valor1, descuento, iva = 0.19;
            if (resp==0)
            {
                descuento = valor * 0.10;
                valor1 = valor - descuento;
                total = valor1 * iva;
                total1 = valor1 + total;
            } else
            {
                total = valor * iva;
                total1 = valor + total;
            }
            return total1;
        }
        static void Main(string[] args)
        {
            double valor;
            int resp;
            Console.WriteLine("Digite el valor de la compra");
            try
            {
                valor = double.Parse(Console.ReadLine());
            }catch(Exception)
            {
                Console.WriteLine("Por favor, ingrese el valor de la compra");
                valor = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("¿Se le autoriza un descuento?\nSI=0 NO=1");
            try
            {
                resp = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Por favor, digite \n¿Se le autoriza un descuento?\nSI=0 NO=1");
                resp = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El total a pagar es: " + Compras(valor,resp));
            Console.ReadKey();

        }
    }
}
