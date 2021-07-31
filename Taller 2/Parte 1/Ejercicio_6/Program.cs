using System;

namespace Taller2_Ej6
{
    class Program
    {

        /*6. Calcular el salario de un empleado, teniendo en cuenta que si el salario bruto 
        es superior a $2.000.000, debe hacerse una retención del 10%.*/
        public static void Main(String[] args)
        {

            double salario, retencion, iva, total;
            Console.Write("Digite el salario del empleado: ");
            try
            {
                salario = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite un valor correcto: ");
                salario = double.Parse(Console.ReadLine());
            }
           

            if (salario > 2000000)
            {
                retencion = salario * 0.10;
                total = salario - retencion;
                Console.WriteLine("-----------------------");
                Console.WriteLine("El salario del empleado");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Salario: $ " + salario);
                Console.WriteLine("Retención: $ " + retencion);
                Console.WriteLine("Total: $ " + total);
            }
            else
            {
                Console.WriteLine("El salario es: $  " + salario);
            }
            Console.ReadKey();
        }
    }
}

