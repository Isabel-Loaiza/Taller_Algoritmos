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
            +"\n2. Programa que pida un número N, que introduzca N sueldos y muestre el sueldo máximo.\n"
            +"\n3. Programa que pida un número de 0 a 99 y mostrarlo escrito.\n "
            +"\n4. Programa que ingrese una letra cualquiera del abecedario y mostrar si se trata de un vocal o una consonante.\n");

            resp=int.Parse(Console.ReadLine());

            switch (resp)
            {
             case 1: 
                 Console.WriteLine("Usted escogio la primera opciòn");
                 Console.WriteLine("");
                 Ej_1();
                 break;

            case 2:
                Console.WriteLine("Usted escogio la segunda opciòn");
                Console.WriteLine("");
                Ej_2();
                 break;

            case 3: 
                Console.WriteLine("Usted escogio la tercera opciòn");
                Console.WriteLine("");
                Ej_3();
                break;

            case 4:
                Console.WriteLine("Usted escogio la cuarta opciòn");
                Console.WriteLine("");
                Ej_4();
                break;

            default:
                Console.WriteLine("El nùmero es erroneo");
                Console.WriteLine("");
                break;
            }
        }

/*1. Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.*/
    static void Ej_1 ()
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

/*
2.Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
 */
        static void Ej_2 (){
        int numero, indice1=0;

            Console.Write("Digite número para introducir sueldos:");
            try {
            numero = int.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Por favor, Digite un número para introducir sueldos:");
                numero = int.Parse(Console.ReadLine());
            }
            double [] sueldo = new double [numero];
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine("Digite sueldo "+(i+1)+": ");
                try {
                    sueldo [i] = double.Parse(Console.ReadLine());
                }catch(Exception) {
                    Console.WriteLine("Por favor, digite sueldo "+(i+1)+": ");
                    sueldo[i]= double.Parse(Console.ReadLine());
                }
            }
            double precio = sueldo [0];
            for (int i = 0; i < sueldo.Length; i++)
            {
                if (sueldo[i]>precio)
                {
                    precio = sueldo[i];
                    indice1=i;
                }
            }
            Console.WriteLine("El sueldo máximo es: "+sueldo[indice1]);
        }

/*
3.Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, 
para 56 mostrar: cincuenta y seis. Pista: separar las unidades y las decenas. 
(unidades = num % 10; decenas = num / 10).
 */
    static void Ej_3 ()
    {
            int num, unidad, decena;
            String uni = "", sobreD = "", dec = "";
            Console.WriteLine("Ingresa un numero: ");
            try{
            num = int.Parse(Console.ReadLine());
            }catch(FormatException){
                Console.WriteLine("Por favor Ingresa un numero: ");
                num = int.Parse(Console.ReadLine());
            }
        
            decena = num / 10;
            unidad = (num % 10) / 1;
        
            switch (unidad) {
                case 1:
                    uni = "uno";
                    break;
                case 2:
                    uni = "dos";
                    break;
                case 3:
                    uni = "tres";
                    break;
                case 4:
                    uni = "cuatro";
                    break;
                case 5:
                    uni = "cinco";
                    break;
                case 6:
                    uni = "seis";
                    break;
                case 7:
                    uni = "siete";
                    break;
                case 8:
                    uni = "ocho";
                    break;
                case 9:
                    uni = "nueve";
                    break;
                default:
                    break;
            }
        
        if (decena == 1 && unidad == 0) {
            sobreD = "diez";
        } else if (decena == 1 && unidad == 1) {
            sobreD = "once";
        } else if (decena == 1 && unidad == 2) {
            sobreD = "doce";
        } else if (decena == 1 && unidad == 3) {
            sobreD = "trece";
        } else if (decena == 1 && unidad == 4) {
            sobreD = "catorce";
        } else if (decena == 1 && unidad == 5) {
            sobreD = "quince";
        } else if (decena == 1 && unidad == 6) {
            sobreD = "dieciseis";
        } else if (decena == 1 && unidad == 7) {
            sobreD = "diecisiete";
        } else if (decena == 1 && unidad == 8) {
            sobreD = "dieciocho";
        } else if (decena == 1 && unidad == 9) {
            sobreD = "diecinueve";
        }
        
        switch (decena) {
            case 2:
                dec = "veinte";
                break;
            case 3:
                dec = "treinta";
                break;
            case 4:
                dec = "cuarenta";
                break;
            case 5:
                dec = "cincuenta";
                break;
            case 6:
                dec = "sesenta";
                break;
            case 7:
                dec = "setenta";
                break;
            case 8:
                dec = "ochenta";
                break;
            case 9:
                dec = "noventa";
                break;
            default:
                break;
        }
        
        if (num < 10) {
            Console.WriteLine("El numero es: " + uni);
        } else if (num < 20) {
            Console.WriteLine("El numero es: " + sobreD);
        } else if (num < 100) {
            if (num % 10 == 0) {
                Console.WriteLine("El numero es: " + dec);
            } else {
                Console.WriteLine("El numero es:" + dec +" y "+ uni);
            }
        }
    }

/*
4.Pedir al usuario que ingrese una letra cualquiera del 
abecedario y mostrar por consola si se trata de un vocal o una consonante.
 */
        static void Ej_4()
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
