using System;
/*

10.Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber cuántas calorías 
consume su cuerpo durante el tiempo que realice una misma actividad. Las actividades que puede realizar 
son únicamente dormir o estar sentado. Los datos que tiene son que estando 
dormido consume 1.08 calorías por minuto y estando sentado en reposo consume 1.66 calorías por minuto.

 */
namespace Ejercicio_10
{
    class Program
    {
        static void Calorias(int respuesta, int minutos){
            double calorias_consumidas;
            if (respuesta==0) {
                calorias_consumidas = minutos*1.08;
                Console.WriteLine($"Gastó {calorias_consumidas} calorías");
            } else if (respuesta==1) {
                calorias_consumidas = minutos*1.66;
                Console.WriteLine($"Gastó {calorias_consumidas} calorías");
            } else {
                Console.WriteLine("No realizó la actividad");
            }
        }
        static void Main(string[] args)
        {
            int minutos, resp;
            Console.WriteLine("¿Qué actividad realizó?\nDORMIR=0 || ESTAR SENTADA=1");
            try {
                resp = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente\n¿Qué actividad realizó?\nDORMIR=0 || ESTAR SENTADA=1");
                resp = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite cuántos minutos realizó la actividad");
            try {
                minutos=int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Digite nuevamente\nDigite cuántos minutos realizó la actividad");
                minutos=int.Parse(Console.ReadLine());
            }
            Calorias(resp,minutos);
        }
    }
}
