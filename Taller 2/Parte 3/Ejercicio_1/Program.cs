using System;
namespace Ejercicio_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int resp;
            Console.Write("Escoja una opciòn: ");
            Console.WriteLine("\n1. Programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.\n"
            +"\n2. Programa que nos pida un número N, introducir N sueldos, y mostrar el sueldo máximo.\n"
            +"\n3. Programa que pida un número de 0 a 99 y mostrarlo escrito.\n "
            +"\n4. Programa que ingrese una letra cualquiera del abecedario y mostrar si se trata de un vocal o una consonante.\n");

            resp=int.Parse(Console.ReadLine());

            switch (resp)
            {
             case 1: 
                 Console.WriteLine("Usted escogio la primera opciòn");
                 Console.WriteLine("");
                 Primo();
                 break;

            case 2:
                Console.WriteLine("Usted escogio la segunda opciòn");
                Console.WriteLine("");
                Maximo();
                 break;

            case 3: 
                Console.WriteLine("Usted escogio la tercera opciòn");
                Console.WriteLine("");
                Numero();
                break;

            case 4:
                Console.WriteLine("Usted escogio la cuarta opciòn");
                Console.WriteLine("");
                Letra();
                break;

            default:
                Console.WriteLine("El nùmero es erroneo");
                Console.WriteLine("");
                break;
            }
        }

/*1. Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.*/
        static void Primo(){
            int numero;
            Console.Write("Digite número: ");

            try 
            {
                numero=int.Parse(Console.ReadLine());
            }catch(Exception) 
            {
                Console.Write("Por favor, Digite número: ");
                numero=int.Parse(Console.ReadLine());
            }

            int contador_primos=0, j;
            bool primo;
            int i = 2;

            while (i<=numero)
            {
                primo=true;
                j=2;
                while (j<=i-1 && primo ==true)
                {
                    if (i%j==0) primo =false;
                    j++;
                }
                if (primo==true)
                    contador_primos++;
                    Console.WriteLine($"{i} es primo");
                i++;
            }
            Console.WriteLine($"De 1 a {numero}, hay {contador_primos} números primos");
        }
        
/*2. Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.*/
        static void Maximo(){
            int numero, indice=0;
            Console.Write("Digite número para introducir sueldos: ");

            try 
            {
                numero = int.Parse(Console.ReadLine());
            }catch(Exception)
            {
                Console.Write("Por favor, Digite número para introducir sueldos: ");
                numero = int.Parse(Console.ReadLine());
            }
            double [] sueldo = new double [numero];
            for (int i = 0; i < sueldo.Length; i++) 
            {
                Console.Write("Digite sueldo "+(i+1)+": ");
            try 
            {
                sueldo[i]= double.Parse(Console.ReadLine());
            }catch(Exception){
                Console.Write("Por favor, digite sueldo "+(i+1)+": ");
                sueldo[i]= double.Parse(Console.ReadLine());
                }
            }
            double precio  =  sueldo [0];
            int indice1=0;
            for (int i = 0; i < sueldo.Length; i++)
            {
                if (sueldo[i]>precio)
                {
                    precio = sueldo[i];
                    indice1=i;
                }
            }
            Console.WriteLine($"El sueldo máximo es: {sueldo[indice]}");
        }

/*3. Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56 mostrar: cincuenta y seis. Pista: separar las 
unidades y las decenas. (unidades = num % 10; decenas = num / 10).*/
        static void Numero (){

            int num, unidad, decena;
            Console.Write("Ingrese un número:");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Ingrese un número, por favor:");
                num = int.Parse(Console.ReadLine());
            }
            decena = num /10;
            unidad = (num%10)/1;

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
                Console.WriteLine("El numero es: " + uni);
            } else if (num < 20) {
                Console.WriteLine("El numero es: " + sobreD);
            } else if (num < 100) {
                if (num % 10 == 0) {
                    Console.WriteLine("El numero es: " + dec);
                } else {
                    Console.WriteLine("El numero es: "+dec+ " y " +uni);
                }
            }
        }
        
/*4. Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un 
vocal o una consonante.*/
        static void Letra ()
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
        
    }
}
