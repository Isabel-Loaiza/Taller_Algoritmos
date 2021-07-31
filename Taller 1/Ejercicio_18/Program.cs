using System;

/*
18. En una universidad los estudiantes pueden pagar el valor de su matrícula en cuatro cuotas de la siguiente forma 
• Primera cuota: 40% 
• Segunda cuota: 25%
• Tercera cuota: 20% 
• Cuarta cuota: 15% 
Diga cuanto es el valor que tiene que pagar por cuota un estudiante.
*/

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorM;

            Console.WriteLine("Ingrese el valor de su matrìcula: ");
            try
            {
                valorM = double.Parse(Console.ReadLine());
            }catch (Exception )
            {
                Console.WriteLine("Por favor, ingrese valores numericos: ");
                valorM = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
            operaciones(valorM);

            Console.ReadKey(true);
        }
       
        static void operaciones(double valorM)
        {
            double cuota1 = valorM * 0.4;
            Console.WriteLine("La primera cuota a pagar es de: " + cuota1);
            double cuota2 = valorM * 0.25;
            Console.WriteLine("La segunda cuota a pagar es de: " + cuota2);
            double cuota3 = valorM * 0.2;
            Console.WriteLine("La tercera cuota a pagar es de: " + cuota3);
            double cuota4 = valorM * 0.15;
            Console.WriteLine("La cuarta cuota a pagar es de: " + cuota4);

            double valorT = cuota1 + cuota2 + cuota3 + cuota4;
            Console.WriteLine(" ");
            Console.WriteLine("El valor total de su matrìcula es de: " + valorT);
        }
    }
}
