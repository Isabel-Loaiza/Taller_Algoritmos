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
            int cantidad;
            double tasa, intereses;
            Console.WriteLine("Digite la cantidad invertida: ");
            try
            {
                cantidad = int.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese la cantidad en nùmeros: ");
                cantidad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite la tasa de interes: ");
            try
            {
                tasa = double.Parse(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Por favor, ingrese la cantidad en nùmeros: ");
                tasa = double.Parse(Console.ReadLine());
            }
            
            intereses = cantidad * tasa;

            if (intereses > 7000)
            {
                Console.WriteLine("Los intereses ganados son $" + intereses + ", superan los $7000");
            }
              else
                  {
                Console.WriteLine("Los intereses ganados son $" + intereses + ", no superan los $7000");
                  }
                Console.WriteLine("El saldo total en la cuenta es: " + (cantidad + intereses));
                  }
        }
    }
