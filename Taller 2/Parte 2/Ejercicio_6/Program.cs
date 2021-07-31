using System;
/*

6.Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el salario bruto es igual o 
superior a $2.000.000, debe hacerse una retención del 10%, si el salario es inferior, la retención será del 3%.

*/
namespace Ejercicio_6
{
    class Program
    {
        static void Mostrar(double salario, double retencion, double iva, double total){
            Console.WriteLine("--------------------");
            Console.WriteLine("El salario del empleado");
            Console.WriteLine("Salario: "+salario);
            Console.WriteLine("Retención: "+retencion);
            Console.WriteLine("Iva: "+iva);
            Console.WriteLine("Total: "+total);
        }
        static void Salario (double salario){
            double retencion, iva, total;
            if (salario>2000000) {
            retencion=salario*0.10;
            iva=salario*0.19;
            total= salario-retencion+iva;
            Mostrar(salario,retencion,iva,total);
        } else {
           retencion=salario*0.03;
            iva=salario*0.19;
            total= salario-retencion+iva;
            Mostrar(salario,retencion,iva,total);
        }
        }
        static void Main(string[] args)
        {
            double salario;
            Console.WriteLine("Digite el salario del empleado: ");
            try {
                salario = double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite el salario del empleado");
                salario = double.Parse(Console.ReadLine());
            }
            Salario(salario);
        }
    }
}
