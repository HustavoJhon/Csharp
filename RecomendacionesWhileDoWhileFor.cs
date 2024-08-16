//! 017 - RECOMENDACIONES DE USO DE WHILE, DO-WHILE, FOR

using System;
using System.Runtime.InteropServices.Marshalling;

class RECOMENDACIONES
{
    static void Main()
    {
        /*
        TODO: IDEAS BASICAS

        * - Do-While: cuando haya que repetir al menos una vez.
        * - While: cuando quiza no hay  que repetir nunca.
        * - For: solo para contadores (resultara poco legible si hay varias condiciones o si "necesitamos" usar "break")

        ? Un break dentro de un bucle se considera mala practica

        * * Existen otros tipos de bucles como Foreach que resulta muy comodo para recorrer estructuras de datos...
        */


        /*
        TODO: EJERCICIOS PROPUESTOS

        * - Muestra los numeros del 1 al 200 que sean a la vez multiplos de 3 y de 7.
        * - Pide al usuario numeros, de uno en uno, hasta que introduzca el valor 0. Tras cada numero, deberas mostrar la suma de todos ellos.
        * - Muestra todos los divisores del numero que introduzca el usuario.
        * - Pide un numero al usuario y responde si es primo.
        * - Da al usuario 5 oportunidades para adivinar una contraseña.
        */

        Console.WriteLine("=====EJERCICIO 1====");
        /*
        for (int i = 1; i <= 200; i++)
        {
            if (i % 2 != 0)
            // if (i % 3 == && i & 7 ==0)
            {
                Console.WriteLine(i);
            }
        }
        */
        Console.WriteLine("=====EJERCICIO 2====");

        int sum = 0;
        int number;

        do
        {
            Console.Write("Introduce un numero: ");
            number = Convert.ToInt32(Console.ReadLine());
            sum += number;
            Console.WriteLine("Resultado: {0}", sum);
        }
        while (number != 0);

        Console.WriteLine("=====EJERCICIO 3====");

        Console.Write("Introduce un numero: ");
        int n1;
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Los divisores de {0} son:", n1);
        for (int i = 1; i <= n1; i++)
        {
            if (n1 % i ==0)
            {
                Console.WriteLine(i);
            }
        }
        
        Console.WriteLine("=====EJERCICIO 4====");

        int n2;
        bool primo = true;

        Console.Write("Introduce un numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (n2 <= 1)
        {
            primo = false;
        }
        else
        {
            for (int i = 2; i < n2; i++)
            {
                if (n2 % i ==0)
                {
                    primo = false;
                    break;
                }
            }
        }
        if (primo)
        {
            Console.WriteLine("{0} es un numero primo", n2);
        }
        else
        {
            Console.WriteLine("{0} no es un numero primo", n2);
        }
        
        Console.WriteLine("=====EJERCICIO 5====");

        int password = 333;
        int attempts = 5;
        bool success = false;

        while (attempts > 0)
        {
            Console.Write("Intro you password: ");
            int input;
            input = Convert.ToInt32(Console.ReadLine());

            if (input == password)
            {
                Console.WriteLine("Welcome!!!");
                success = true;
                break;
            }
            else
            {
                attempts--;
                Console.WriteLine("Incorrect attempts: {0}", attempts);
            }
        }
        if (!success)
        {
            Console.WriteLine("Has agotado todos los intentos");
        }
    }
}