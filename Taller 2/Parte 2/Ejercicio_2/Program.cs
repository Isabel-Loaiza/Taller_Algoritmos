using System;
/*
2.Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o más se 
aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento del 10%
 */
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCamisas;
            double suma = 0, descuento, total;

            Console.WriteLine("Digite número de prendas a comprar: ");
            try
            {
                nCamisas = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese un número: ");
                nCamisas = int.Parse(Console.ReadLine());
            }
            double[] precio = new double[nCamisas];

            for (int i = 0; i < precio.Length; i++)
                {
                Console.WriteLine("Digite precio de la camisa " + (i + 1) + ": ");
                try
                {
                    precio[i] = double.Parse(Console.ReadLine());
                }catch (Exception)
                {
                    Console.WriteLine("Por favor, ingrese valores numèricos: ");
                    precio[i] = double.Parse(Console.ReadLine());
                }
                    suma += precio[i];
                }
            if (nCamisas >= 3)
            {
                descuento = suma * 0.20;
                total = suma - descuento;
            }
             else
             {
                descuento = suma * 0.10;
                total = suma - descuento;
             }
            Console.WriteLine("El total a pagar por la(s) " + nCamisas + " camisa(s) es de: " + total);
        }
    }
}
