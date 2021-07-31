using System;

namespace Taller1_Ej14
{
    class Program
    {

        /*14.Se trata de escribir el algoritmo que permita emitir la factura correspondiente a una compra de 
        varios artículos(4) determinados, del que se adquieren una o varias unidades. El IVA es del 19 %.*/

        float Compra;
        float IVA;
        float Factura;

        static void Imprimir(float Acum)
        {
            float IVA = (float)(Acum * 0.19);
            float Total = Acum + IVA;
            Console.WriteLine("El total es: " + Total);
        }

        public static void Main(String[] args)
        {
            float Acum = 0;
            int Cant;

            Console.WriteLine("Número de artículos que desea comprar: ");
            try
            {
                Cant = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite un número: ");
                Cant = int.Parse(Console.ReadLine());
            }

            float[] valorProductos = new float[Cant];
            float Valor;
            for (int i = 0; i < valorProductos.Length; i++)
            {

                Console.WriteLine("Valor Producto " + (i + 1) + ": ");
                try
                {
                    Valor = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite un valor correcto: ");
                    Valor = float.Parse(Console.ReadLine());
                }

                valorProductos[i] = Valor;
                Acum += valorProductos[i];
            }

            Imprimir(Acum);
        }
    }
}
