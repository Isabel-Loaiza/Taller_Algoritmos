using System;
/*
3.Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, 
para 56 mostrar: cincuenta y seis. Pista: separar las unidades y las decenas. 
(unidades = num % 10; decenas = num / 10).
 */
namespace Ejercicio_3
{
    class Program
    {
        static void Numero (int num, int decena, int unidad){
            String uni ="", sobreD="", dec="";
            if (unidad==1)
            {
                uni = "uno";
            } else if (unidad==2)
            {
                uni ="dos";
            }else if (unidad==3)
            {
                uni="tres";
            }else if (unidad==4)
            {
                uni="cuatro";
            }else if (unidad==5)
            {
                uni="cinco";
            }else if (unidad==6)
            {
                uni="seis";
            }else if (unidad==7)
            {
                uni="siete";
            }else if (unidad==8)
            {
                uni="ocho";
            }else if (unidad==9)
            {
                uni="nueve";
            }

            if (decena==1 && unidad==0)
            {
                sobreD = "diez";
            }else if (decena==1 && unidad==1)
            {
                sobreD = "once";
            }else if (decena==1 && unidad==2)
            {
                sobreD = "doce";
            }else if (decena==1 && unidad==3)
            {
                sobreD = "trece";
            }else if (decena==1 && unidad==4)
            {
                sobreD = "catorce";
            }else if (decena==1 && unidad==5)
            {
                sobreD = "quince";
            }else if (decena==1 && unidad==6)
            {
                sobreD = "diesiseis";
            }else if (decena==1 && unidad==7)
            {
                sobreD = "diesisiete";
            }else if (decena==1 && unidad==8)
            {
                sobreD = "diesiocho";
            }else if (decena==1 && unidad==9)
            {
                sobreD = "diesinueve";
            }

            if (decena == 2) {
                dec = "veinte";
            } else if (decena == 3) {
                dec = "treinta";
            } else if (decena == 4) {
                dec = "cuarenta";
            } else if (decena == 5) {
                dec = "cincuenta";
            } else if (decena == 6) {
                dec = "sesenta";
            } else if (decena == 7) {
                dec = "setenta";
            } else if (decena == 8) {
                dec = "ochenta";
            } else if (decena == 9) {
                dec = "noventa";
            }

            if (num < 10) {
                Console.WriteLine("El numero es: " + unidad);
            } else if (num < 20) {
                Console.WriteLine("El numero es: " + sobreD);
            } else if (num < 100) {
                if (num % 10 == 0) {
                    Console.WriteLine("El numero es: " + dec);
                } else {
                    Console.WriteLine("El numero es: "+dec+uni);
                }
            }
        }
        static void Main(string[] args)
        {
            int num, unidad, decena;
            Console.WriteLine("Ingrese un número:");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un número, por favor:");
                num = int.Parse(Console.ReadLine());
            }
            decena = num /10;
            unidad = (num%10)/1;
            Numero(num, decena, unidad);

        }
    }
}
