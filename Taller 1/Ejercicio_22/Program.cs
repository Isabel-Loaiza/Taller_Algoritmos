using System;
/*

22)Se tienen tres baldes de agua, uno de cinco litros, otros de tres litros y otro de un litro; 
si el de un litro tarda una hora y media en llenarse, resuelva cuanto tiempo pueden tardar en llenarse los otros baldes. 
Si tiene tres baldes, pero se desconoce su tamaño debe de resolver igualmente el ejercicio.

*/
namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int balde1 = 90, tamaño, tiempo;


            Console.WriteLine("¿De cuántos litros es el balde?: ");
            try
            {
                tamaño = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite un número ");
                tamaño = int.Parse(Console.ReadLine());
            }

            tiempo = balde1 * tamaño;
            double resultado = tiempo / 6;
            String uni = "", dec = "";
            int decena = (int)resultado / 10;
            int unidad = (int)(resultado % 10) / 1;
            switch (unidad)
            {
                case 5:
                    uni = "y treinta minutos";
                    break;
                case 0:
                    uni = "";
                    break;
            }

            switch (decena)
            {
                case 1:
                    dec = "Una hora";
                    break;
                case 2:
                    dec = "Dos horas";
                    break;
                case 3:
                    dec = "Tres horas";
                    break;
                case 4:
                    dec = "Cuatro horas";
                    break;
                case 5:
                    dec = "Cinco horas";
                    break;
                case 6:
                    dec = "Seis horas";
                    break;
                case 7:
                    dec = "Siete horas";
                    break;
                case 8:
                    dec = "Ocho horas";
                    break;
                case 9:
                    dec = "Nueve horas";
                    break;
                default:
                    break;
            }

            if (resultado < 100)
            {
                if (resultado % 10 == 0)
                {
                    Console.WriteLine("El balde se llenaría en: " + dec);
                }
                else
                {
                    Console.WriteLine("El balde se llenaría en: " + dec + " " + uni);
                }
            }
            else
            {
                Console.WriteLine("El balde se llenaría en: " + decena + " horas " + uni);
            }
        }
    }
}