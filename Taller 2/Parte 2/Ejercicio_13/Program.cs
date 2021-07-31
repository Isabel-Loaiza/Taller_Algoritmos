using System;
/*

13.Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones: 
Si los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial será del 15% del valor de la vivienda 
y el resto, se distribuirá en 120 cuotas mensuales con un interés del 2% mensual. 
Si los ingresos del comprador son inferiores a $1.200.000, la cuota inicial será del 30% del valor de la vivienda y el resto,
lo distribuirá en 84 cuotas mensuales con un interés del 1% mensual. La constructora desea saber cuánto debe pagar un 
comprador por concepto de cuota inicial y cuánto por cada cuota mensual.

 */
namespace Ejercicio_13
{
    class Program
    {
        static void Cuotas(double ingreso_comp, double valor_vivienda){
            double cuota_inicial,restante,cuota_mensual1,intereses,total;
            if (ingreso_comp>=1200000)
            {
                cuota_inicial = valor_vivienda * 0.15;
                restante=valor_vivienda-cuota_inicial;
                cuota_mensual1=restante/120;
                intereses=cuota_mensual1*0.02;
                total=cuota_mensual1+intereses;
            } else {
                cuota_inicial = valor_vivienda * 0.30;
                restante=valor_vivienda-cuota_inicial;
                cuota_mensual1=restante/84;
                intereses=cuota_mensual1*0.01;
                total=cuota_mensual1+intereses;
            }
            Console.WriteLine($"Un comprador por concepto de cuota inicial, pagará {cuota_inicial}\nY cada cuota mensual pagará: {total}");
        }
        static void Main(string[] args)
        {
            double ingreso_com, valor_vivienda;
            Console.WriteLine("Digite el ingreso del comprador: ");
            try {
                ingreso_com=double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite nuevamente el ingreso del comprador: ");
                ingreso_com=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite el valor de la vivienda: ");
            try {
                valor_vivienda=double.Parse(Console.ReadLine());
            }catch(Exception) {
                Console.WriteLine(" Por favor, digite el valor de la vivienda: ");
                valor_vivienda=double.Parse(Console.ReadLine());
            }
            Cuotas(ingreso_com, valor_vivienda);
        }
    }
}
