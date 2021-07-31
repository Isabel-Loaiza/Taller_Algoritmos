using System;
/*

12.Elaborar un algoritmo que permita calcular el valor total a pagar en una papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán $2.000 por cada uno, mientras que, si lleva menos, 
se le cobrarán $2.500 por cada uno.

 */
namespace Ejercicio_12
{
    class Program
    {
        static void Resultado(int nCuadernos){
            double resultado;
            resultado = nCuadernos>=5?nCuadernos*2000:resultado=nCuadernos*2500;
            Console.WriteLine($"El total a pagar por los {nCuadernos} cuaderno(s), es de: {resultado}");
        }
        static void Main(string[] args)
        {
            int nCuadernos;
            Console.WriteLine("¿Cuántos cuadernos va a llevar?");
            try {
                nCuadernos=int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor digite en número ¿Cuántos cuadernos va a llevar?");
                nCuadernos=int.Parse(Console.ReadLine());
            }
            Resultado(nCuadernos);
        }
    }
}
