using System;
/*
4.Pedir al usuario que ingrese una letra cualquiera del 
abecedario y mostrar por consola si se trata de un vocal o una consonante.
 */
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char letra;
            Console.WriteLine("Digite letra");
            try{
            letra = char.Parse(Console.ReadLine());
            }catch(FormatException){
                Console.WriteLine("Por favor digite una letra");
                letra = char.Parse(Console.ReadLine());
            }
            switch (letra) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es una vocal");
                    break;
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Es una vocal");
                    break;
                default:
                    Console.WriteLine("Es una consonante");
                    break;
            }
        }
    }
}
