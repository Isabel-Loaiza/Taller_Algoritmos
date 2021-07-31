using System;
/*

2.Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.

 */
namespace Ejercicio_2
{
    class Program
    {
        static int Maximo (double [] sueldo){
            double precio  =  sueldo [0];
            int indice1=0;
            for (int i = 0; i < sueldo.Length; i++)
            {
                if (sueldo[i]>precio)
                {
                    precio = sueldo[i];
                    indice1=i;
                }
            }
            return indice1;
        }
        static void Main(string[] args)
        {
            int numero, indice=0;
            Console.WriteLine("Digite número para introducir sueldos: ");
            try {
                numero = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, Digite número para introducir sueldos: ");
                numero = int.Parse(Console.ReadLine());
            }
            double [] sueldo = new double [numero];
            for (int i = 0; i < sueldo.Length; i++) {
                Console.WriteLine("Digite sueldo "+(i+1)+": ");
                try {
                    sueldo[i]= double.Parse(Console.ReadLine());
                }catch(Exception){
                    Console.WriteLine("Por favor, digite sueldo "+(i+1)+": ");
                    sueldo[i]= double.Parse(Console.ReadLine());
                }
            }
            indice=Maximo(sueldo);
            Console.WriteLine(indice);
            Console.WriteLine($"El sueldo máximo es: {sueldo[indice]}");
            
        }
    }
}
