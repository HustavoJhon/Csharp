//! 015 - CONTADORES. BUCLES CON "FOR"

using System;
using System.Security.Cryptography.X509Certificates;

class Contadores
{
    static void Main()
    {
        int i; //? nombre habitual para una variable que actue de contador ("indice")

        i = 1;
        
        
        while (i <= 10)
        {
            Console.WriteLine( i );
            i = i + 1; //? es igual a i++
        }
        

        for (i = 10 ; i  <= 20; i++)
        {
            Console.WriteLine( i );
        }
        

        /*
        TODO: EJERCICIOS PROPUESTO
        * - Muestra los numeros del 1 al 20
        * - Muestra los pares del 2 al 16
        * - Muestra los impares del 15 al 5, descendiendo
        */ 

        Console.WriteLine("--EJERCICIO 1--");

        for (int x = 1; x <= 20; x++)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("--EJERCICIO 2--");

        for (int y = 2; y <= 16; y++)
        {
            Console.WriteLine(y);
            y++;
        }

        Console.WriteLine("--EJERCICIO 3--");

        for (int z = 15; z >= 5; z-- )
        {
            if (z % 2 != 0)
            {
                Console.WriteLine(z);
            }
        }
    }
}