using System;
/*
11.Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica. 
La empresa, dependiendo del valor de la compra, decidirá la forma en que le pagará al fabricante. 
Si el valor de la compra excede o es igual a $5.000.000, la empresa tendrá la capacidad de pagar con 
recursos propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el resto lo pagará 
solicitando un crédito al fabricante. Si el monto total de la compra no excede de $5.000.000, 
la empresa tendrá la capacidad de pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando 
un crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.

Si la compra es mayor o igual a 5.000.0000 paga de la siguiente manera(
    - recursos propios el 55%
    - prestado a un banco el 30%
    - el resto con un credito al fabricante (15%)
)

si la compra no es mayor a 5.000.000 paga de la siguiente manera(
    - recursos propios el 70%
    - el 30% lo paga con un credito al fabricante y a eso le cobra el 15% del interes
)
 */
namespace Ejercicio_11
{
        class Program
    {
        static void ValorMenos(double valorCompra){
            double total, recursosP, credito, interes;
            recursosP = valorCompra * 0.70;
            credito = valorCompra * 0.30;
            interes = credito * 0.15;
            total = recursosP + credito + interes;
           Console.WriteLine($"Pago por las piezas\nRecursos propios: {recursosP}\nCredito al Fabricante: {credito}\nIntereses: {interes}\nTotal: {total}");

        }
        static void ValorMas(double valorCompra){
            double total=0, recursosP, banco, credito;
            recursosP = valorCompra * 0.55;
            banco = valorCompra * 0.30;
            credito = valorCompra * 0.15;
            total = recursosP + banco + credito;
            Console.WriteLine($"Pago por las piezas\nRecursos propios: {recursosP}\nPrestacion de un banco:{banco} \nCredito al Fabricante: {credito}\nTotal: {total}");
        }

        static void Main(string[] args)
        {
            double valorCompra;
            Console.WriteLine("Digite valor de la compra: ");
            try {
                valorCompra=double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite valor de la compra: ");
                valorCompra=double.Parse(Console.ReadLine());
            }
            if (valorCompra>=5000000) ValorMas(valorCompra);
            else if (valorCompra<5000000) ValorMenos(valorCompra);
        }
    }
}
