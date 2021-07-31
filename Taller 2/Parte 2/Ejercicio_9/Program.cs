using System;
/*

9.Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: 
Si trabaja 40 horas o menos, se le paga a $10.000 la hora
Si trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras 40 horas y $15.000 por cada una de las horas extras.

 */
namespace Ejercicio_9
{
    class Program
    {
        static void Salario(int hora){
            double resultado, resultado2, restante, total;
            if (hora <= 40) {
            resultado = hora * 10000;
            Console.WriteLine("Su salario semanal es: " + resultado);
        } else {
            restante = hora - 40;
            resultado = 40 * 10000;
            resultado2 = restante * 15000;
            total = resultado + resultado2;
            Console.WriteLine($"Su salaio normal sería {resultado}");
            Console.WriteLine($"Sus horas extras fueron: {restante}");
            Console.WriteLine($"Su salario con sus horas extras es de: {total}");
        }
        }
        static void Main(string[] args)
        {
            int hora;
           
            Console.WriteLine("Digite horas trabajadas: ");
            try {
                hora = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("digite por favor cuántas horas trabajó: ");
                hora = int.Parse(Console.ReadLine());
            }
            Salario(hora);
        }
    }
}
