using System;

/*
8.Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre la cantidad 
que tiene en inversión en el banco. El decidirá reinvertir los intereses 
siempre y cuando no excedan a $7000, y en ese caso desea saber cuánto dinero tendrá finalmente en su cuenta.
*/

namespace Ejercicio_8
{
    class Program
    {
        public static void Main(String[] args)
        {
            double dineroBanco, interes, valor, reinversion;
            Console.WriteLine("Digite cuanto dinero tiene en el banco: ");
            dineroBanco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor del interes: ");
            interes = double.Parse(Console.ReadLine());
            valor = dineroBanco*(interes/100);

            if (valor<7000)
            {
                reinversion = valor + dineroBanco;
                Console.WriteLine("Has reinvertido. Dinero total: "+reinversion);
            }else{
                Console.WriteLine("Dinero total: "+valor);
            }
        }
    }
}
