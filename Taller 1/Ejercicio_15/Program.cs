using System;

namespace Taller1_Ej15
{
    class Program
    {

        /*15. Suponga que tiene Ud. una tienda y desea registrar las ventas en una computadora.
         Diseñe un algoritmo en pseudocódigo que lea por cada cliente: 
       •	El monto de la venta, calcule e imprima el IVA.
       •	calcule e imprima el total a pagar 
       •	lea la cantidad con la que paga el cliente (solo efectivo), calcule e imprima el cambio.*/
        
        static void compra()
        {
            int cantidadProductos;
            string producto;
            float valor, montoVenta = 0, IVA, billete, devuelta;

            Console.Write("Cantidad de productos a comprar: ");
            try
            {
                cantidadProductos = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor digite un número: ");
                cantidadProductos = int.Parse(Console.ReadLine());
            }
            

            string[] nombreProductos = new string[cantidadProductos];
            float[] valorProductos = new float[cantidadProductos];

            for (int i = 0; i < nombreProductos.Length; i++)
            {
                Console.Write("Nombre Producto: ");
                producto = Console.ReadLine();
                nombreProductos[i] = producto;

                Console.Write("Valor Producto: ");
                try
                {
                    valor = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Por favor digite un valor correcto: ");
                    valor = float.Parse(Console.ReadLine());
                }
               
                valorProductos[i] = valor;
            }

            for (int i = 0; i < nombreProductos.Length; i++)
            {
                montoVenta += valorProductos[i];
            }

            Console.Write("valor del Billete: ");
            try
            {
                billete = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor digite un valor correcto: ");
                billete = float.Parse(Console.ReadLine());
            }
     

            while (billete < montoVenta)
            {
                Console.Write("Billete insuficiente");
                Console.Write("Digite valor billete: ");
                billete = float.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            devuelta = billete - montoVenta;
            IVA = montoVenta * 0.19F;

            Console.WriteLine("");
            Console.WriteLine("Monto: $ " + montoVenta + "\nIVA: $ " + IVA + "\nDevuelta: $ " + devuelta);


        }
        public static void Main(string[] args)
        {
            compra();

        }
    }
}



    


