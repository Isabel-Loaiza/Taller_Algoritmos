using System;
/*

8.Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener una persona 
por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica cuando 

el sexo es femenino, es: 
numpulsaciones = (220-edad)/10

y si el sexo es masculino:
numpulsaciones = (210-edad)/10

 */
namespace Ejercicio_8
{
    class Program
    {
        private const string Value = "";

        static void Formula (int edad, char genero){
            double nPulsacion;
            if (genero.Equals('m')) nPulsacion = (210 - edad) / 10;
            else if (genero.Equals('f'))nPulsacion = (220 - edad) / 10;
            else{ 
                Console.WriteLine("No digitó un género"); 
                nPulsacion=0;
            }
            Console.WriteLine($"La pulsación es: {nPulsacion}");
        }
        static void Main(string[] args)
        {
            int edad;
            char genero;
            Console.WriteLine("Digite la edad: ");
            try {
                edad = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, digite su edad: ");
                edad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite si es Masculino(m) o Femenino(f): ");
            try {
                genero = Convert.ToChar(Console.ReadLine());
            } catch(Exception) {
                Console.WriteLine("\nSe le recomienda no poner números\nPor favor, Digite UNA SOLA LETRA dependiendo de su caso\nsi es Masculino(m) o Femenino(f):  ");
                genero = Convert.ToChar(Console.ReadLine());
            }
            Formula(edad, genero);           

        }
    }
}
