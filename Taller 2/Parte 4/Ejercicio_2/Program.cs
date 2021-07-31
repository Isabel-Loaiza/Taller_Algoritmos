using System;
/*
2.Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
 */
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, indice1=0;

            Console.WriteLine("Digite número para introducir sueldos:");
            try {
            numero = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, Digite un número para introducir sueldos:");
                numero = int.Parse(Console.ReadLine());
            }
            double [] sueldo = new double [numero];
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine("Digite sueldo "+(i+1)+": ");
                try {
                    sueldo [i] = double.Parse(Console.ReadLine());
                }catch(Exception) {
                    Console.WriteLine("Por favor, digite sueldo "+(i+1)+": ");
                    sueldo[i]= double.Parse(Console.ReadLine());
                }
            }
            double precio = sueldo [0];
            for (int i = 0; i < sueldo.Length; i++)
            {
                if (sueldo[i]>precio)
                {
                    precio = sueldo[i];
                    indice1=i;
                }
            }
            Console.WriteLine("El sueldo máximo es: "+sueldo[indice1]);
        }
    }
}
