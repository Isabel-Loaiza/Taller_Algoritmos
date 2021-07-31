using System;

namespace Taller2_Ej5
{
    class Program
    {
        /*5. Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la 
        distancia a recorrer y sabiendo que esta es superior a 1.000 km, la línea 
        aérea le hace un descuento del 30%. El precio por kilómetro es de $150.*/
        public static void Main(String[] args)
        {
           
            double distancia, precio_km, descuento, total;
            Console.Write("Digite distancia en kilometros: ");
            try
            {
                distancia = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite una distancia correcta: ");
                distancia = double.Parse(Console.ReadLine());
            }
            
            precio_km = distancia * 150;

            if (distancia > 1000) descuento = precio_km * 0.3;
            else descuento = 0;

            total = precio_km - descuento;

            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Precio en kilometros: $ " + precio_km);
            Console.WriteLine(" ");
            Console.WriteLine("Descuento del (30 por ciento):  $ " + descuento);
            Console.WriteLine(" ");
            Console.WriteLine("Valor de precio del pasaje:  $ " + total);
            Console.WriteLine(" ");
        }
    }
}
