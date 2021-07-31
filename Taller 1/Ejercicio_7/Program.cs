using System;
/*

7.Dada una cantidad de tiempo medida en horas, minutos y segundos, diga a cuántos segundos equivale.

 */
namespace Ejercicio_7
{
    class Program
    {
        static int segundosMinuto(int minutos) => minutos * 60;
        static int segundosHora(int hora) => hora * 3600;
        static void mostrar (int hora, int minutos, int segundos)
        {
            int TotalS = hora + minutos + segundos;
            Console.WriteLine($"Equivale a {TotalS} segundos");
        }

        static void Main (String[] args)
        {
            int horas, minutos, segundo;
            Console.WriteLine("Digite horas");
            try {
                horas = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente horas");
                horas = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite minutos:");
            try {
                minutos = int.Parse(Console.ReadLine());
            }catch(Exception) {
                Console.WriteLine("Digite nuevamente minutos");
                minutos = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite segundo:");
            try {
                segundo = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente segundos");
                segundo = int.Parse(Console.ReadLine());
            }
            mostrar(segundosHora(horas), segundosMinuto(minutos), segundo);

        }
    }
}
