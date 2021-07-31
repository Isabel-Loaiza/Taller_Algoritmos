using System;

namespace ejercicio23
{
    class Program
    {
        /*23) Una persona tarda 5 horas en subir una montaña de 7 metros, 
         * si un escalador desea subir más o menos de la montaña, 
         * cuanto tiempo tarda en subir. Debe de resolver el ejercicio. */
        static void Main(string[] args)
        {
            int altura, tiempo = 0;
            Console.Write("Ingrese la altura a la que llego: ");
            try
            {

                altura = int.Parse(Console.ReadLine());
            }
            catch (Exception) {
                Console.Write("Digite un valor númerico.");
                altura = int.Parse(Console.ReadLine());
            }
           

            tiempo = (altura * 5) / 7;
            Console.WriteLine("El tiempo en que se demoro en subir fue: " + tiempo + " horas");

        }
    }
}
