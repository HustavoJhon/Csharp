//! 016 - BREAK, CONTINUE, GOTO

using System;
class ForBreak
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            // ? se tratan de ordenes que se deberian evitar usar
            //* goto solo es aceptable en caso de necesidad de salir de dos bucles anidados
            goto fin;
            // break;
            // continue;
            Console.WriteLine(i);
        }

        fin :
        Console.WriteLine("Adios");

        //? goto permite saltar a cualquier punto del programa
        for (int j = 1; j < 5; j++)
        {
            for (int i = 1; i < 5; i++)
            {
                if (i == 5)
                {
                    goto ultimo;
                }
                Console.WriteLine(i);
            }
        }
        ultimo:
        Console.WriteLine("Adios");

        /*
        TODO: EJERCICIO PROPUESTO:
        * - Muestra los numeros del 1 al 20, excepto el 10, usando "Continue"
        * - Haz un programa que pueda mostrar los numeros del 1 al 20, pero detenlo en 10, usando "break"
        */

        Console.WriteLine("--EJERCICIO 1--");

        for (int i = 1; i <= 20; i++)
        {
            if(i == 10)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("--EJERCICIO 1--");

        for (int i = 1; i <= 20; i++)
        {
            if (i == 11)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}