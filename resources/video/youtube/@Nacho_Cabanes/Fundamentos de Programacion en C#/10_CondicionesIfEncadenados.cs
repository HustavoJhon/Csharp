//! 010 - CONDICIONES CON "IF" ENLAZAR CONDICIONES

using System;

class Positivo
{
    static void Main()
    {
        int n;

        Console.Write("Dime un numero: ");
        n = Convert.ToInt32( Console.ReadLine() );

        /*
        ? or = ||
        ? and = &&
        ? not = !
        */

        // if ((n > 0) || (n == 0))
        // if ((n > 0) && (n == 0))
        if (n > 0)
        {
            Console.WriteLine("Es positivo");
        }
        else if (n == 0)
        {
            Console.WriteLine("Es cero");
        }
        else
        {
            Console.WriteLine("Es negativo");
        }

        /*
        TODO:EJERCIO PROPUESTO 
        * Pide al usuario tres numeros enteros y muestra el mayor de los tres. Comprueba que se comporta bien con casos como:
        - 3, 5, 7
        - 7, 5, 3
        - 5, 5, 3
        - 5, 5, 5
        */

        Console.WriteLine("--EJERCICIO--");

        int one, two, three;

        Console.Write("Primer Numero: ");
        one = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Segundo Numero: ");
        two = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Tercer Numero: ");
        three = Convert.ToInt32( Console.ReadLine() );

        if ((one >= two) && (one >= three))
        {
            Console.WriteLine("El numero mayor es: {0}", one);
        }

        else if ((two > one) && (two > three))
        {
            Console.WriteLine("El numero mayor es: {0}", two);
        }
        else if ((one == two) && (one < three))
        {
            Console.WriteLine("El numero {0} y {1} son iguales", one, two);
        }
        else if ((one == two) && (one == three) && (two == three))
        {
            Console.WriteLine("Son numeros Iguales: {0} - {1} - {2}", one,two,three);
        }
        else 
        {
            Console.WriteLine("El numero mayor es: {0}", three);
        }

    }
}