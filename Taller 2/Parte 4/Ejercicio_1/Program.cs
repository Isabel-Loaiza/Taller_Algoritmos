using System;
/*
 1.	Realizar un programa que nos pida un número n, y nos 
diga cuantos números hay entre 1 y n que son primos.
 */
namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num, cont_pri=0;
            Boolean primo;

            Console.WriteLine("Introduzca el número:");
            try{
            num = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor Introduzca el número:");
                num = int.Parse(Console.ReadLine());
            }
            for (int i = 2; i <=num; i++)
            {
                primo = true;
                j = 2;
                while (j <= i - 1 && primo ==true)
                {
                    if (i % j ==0)
                    {
                        primo = false;
                    }
                    j++;
                }
                if (primo == true)
                {
                    cont_pri ++;
                    Console.WriteLine(i + ("es primo"));
                }
            }
            Console.WriteLine("En el rango 1.."+num+", hay "+cont_pri+" números primos");
        }
    }
}
