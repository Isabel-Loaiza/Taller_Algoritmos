using System;
/*
4.Pedir al usuario que ingrese una letra cualquiera del abecedario y 
mostrar por consola si se trata de un vocal o una consonante.
 */
namespace Ejercicio_4
{
    class Program
    {
        static void Letra (char letra){
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
             Console.WriteLine("Es una Vocal");   
            } else if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
             Console.WriteLine("Es una Vocal");   
            } else{
                Console.WriteLine("Es una consonante");
            }
        }
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Digite una Letra:");
            try
            {
                letra = char.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor, Digite una Letra:");
                letra = char.Parse(Console.ReadLine());
            }
            Letra(letra);
        }
    }
}
