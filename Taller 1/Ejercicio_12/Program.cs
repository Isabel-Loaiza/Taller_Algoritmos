using System;

namespace Taller1_Ej12
{
    class Program
    {       
            /*12.Un maestro desea saber qué porcentaje de hombres y qué porcentaje de mujeres hay en un grupo de alumnos*/
            static void porcentajes(int hombres, int mujeres)
            {
                int suma, porH, porM;
                suma = hombres + mujeres;
                porH = (hombres * 100) / suma;
                porM = (mujeres * 100) / suma;
                Console.WriteLine("Porcentaje de Hombres: " + porH + "%");
                Console.WriteLine("Porcentaje de Mujeres: " + porM + "%");
            }

                public static void Main(String[] args)
                {
                int Hombres, Mujeres;

                Console.WriteLine("Digite el número de hombres: ");
                try {
                Hombres = int.Parse(Console.ReadLine());
                }catch (Exception) {
                Console.WriteLine("Por favor digite un número: ");
                Hombres = int.Parse(Console.ReadLine());
                }           
                
                Console.WriteLine("Digite el número de mujeres: ");
                try{
                Mujeres = int.Parse(Console.ReadLine());
                } catch (Exception){
                Console.WriteLine("Por favor digite un número: ");
                Mujeres = int.Parse(Console.ReadLine());
                }
                porcentajes(Hombres, Mujeres);
            }
        }
    }


